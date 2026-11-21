using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020019D2 RID: 6610
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class VisionRecommendBranchFetterItem : GridProxyAbstract<VisionFetterRecommendInfo>
{
	// Token: 0x060104D7 RID: 66775 RVA: 0x004C2CC0 File Offset: 0x004C0EC0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick))
		};
	}

	// Token: 0x060104D8 RID: 66776 RVA: 0x004C2D40 File Offset: 0x004C0F40
	protected override UniTask OnBeforeStartAsync()
	{
		VisionRecommendBranchFetterItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionRecommendBranchFetterItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060104D9 RID: 66777 RVA: 0x004C2D83 File Offset: 0x004C0F83
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
		extendToggle.bLockStateOnSelect = true;
	}

	// Token: 0x060104DA RID: 66778 RVA: 0x004C2DA3 File Offset: 0x004C0FA3
	[NullableContext(1)]
	public override void Refresh(VisionFetterRecommendInfo data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.FetterItem.Refresh(data, isSelected, gridIndex);
		this.RefreshSkillBranchItem();
	}

	// Token: 0x060104DB RID: 66779 RVA: 0x004C2DC0 File Offset: 0x004C0FC0
	private void RefreshSkillBranchItem()
	{
		PhantomRecommend? config = ConfigPhantomRecommendByRoleId.GetConfig(this.RoleId, true);
		bool flag = config != null && config.GetValueOrDefault().PhantomPlanParamIdLength >= 1 && RoleModel.Instance.IsRoleHasBranch(this.RoleId);
		int? num = (config != null) ? new int?(config.GetValueOrDefault().GetRecommendFetterGroupsArray().IndexOf(this.Data.GetRecommendFetterGroupId())) : null;
		bool flag2;
		if (flag)
		{
			int? num2 = num;
			int num3 = 0;
			if (num2.GetValueOrDefault() >= num3 & num2 != null)
			{
				num2 = num;
				int? num4 = (config != null) ? new int?(config.GetValueOrDefault().PhantomPlanParamIdLength) : null;
				flag2 = (num2.GetValueOrDefault() < num4.GetValueOrDefault() & (num2 != null & num4 != null));
				goto IL_E9;
			}
		}
		flag2 = false;
		IL_E9:
		bool flag3 = flag2;
		base.GetItem(1).SetUIActive(flag3);
		if (!flag3)
		{
			return;
		}
		int skillBranchId = ConfigPhantomPlanParamById.GetConfig(config.Value.PhantomPlanParamId(num.Value), true).Value.SkillBranchId;
		int roleBranchIndexById = RoleModel.Instance.GetRoleBranchIndexById(this.RoleId, skillBranchId);
		if (skillBranchId <= 0 || roleBranchIndexById < 0)
		{
			base.GetItem(1).SetUIActive(false);
			return;
		}
		RecommendSkillBranchItem skillBranchItem = this.SkillBranchItem;
		if (skillBranchItem != null)
		{
			skillBranchItem.SetActiveBranchIndex(roleBranchIndexById);
		}
		RecommendSkillBranchItem skillBranchItem2 = this.SkillBranchItem;
		if (skillBranchItem2 == null)
		{
			return;
		}
		skillBranchItem2.RefreshIcon(new Func<int, string>(this.RefreshSkillBranchIconHandler));
	}

	// Token: 0x060104DC RID: 66780 RVA: 0x004C2F53 File Offset: 0x004C1153
	public void SetRoldId(int roleId)
	{
		this.RoleId = roleId;
	}

	// Token: 0x060104DD RID: 66781 RVA: 0x004C2F5C File Offset: 0x004C115C
	[NullableContext(1)]
	private string RefreshSkillBranchIconHandler(int index)
	{
		int roleBranchIdByIndex = RoleModel.Instance.GetRoleBranchIdByIndex(this.RoleId, index);
		SkillBranch? skillBranchConfigById = RoleConfig.Instance.GetSkillBranchConfigById(roleBranchIdByIndex);
		if (skillBranchConfigById == null)
		{
			return string.Empty;
		}
		return skillBranchConfigById.Value.Icon;
	}

	// Token: 0x060104DE RID: 66782 RVA: 0x004C2FA5 File Offset: 0x004C11A5
	private void OnToggleClick(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			Action<int> onSelectedCallback = this.OnSelectedCallback;
			if (onSelectedCallback == null)
			{
				return;
			}
			onSelectedCallback(base.GridIndex);
		}
	}

	// Token: 0x060104DF RID: 66783 RVA: 0x004C2FC1 File Offset: 0x004C11C1
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true, fireEvent);
	}

	// Token: 0x060104E0 RID: 66784 RVA: 0x004C2FCB File Offset: 0x004C11CB
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false, fireEvent);
	}

	// Token: 0x060104E1 RID: 66785 RVA: 0x004C2FD5 File Offset: 0x004C11D5
	private void SetToggleState(bool isSelected, bool fireEvent = false)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x060104E2 RID: 66786 RVA: 0x004C2FF2 File Offset: 0x004C11F2
	[NullableContext(1)]
	public override object GetKey(VisionFetterRecommendInfo data, int displayIndex)
	{
		return data;
	}

	// Token: 0x04009055 RID: 36949
	public Action<int> OnSelectedCallback;

	// Token: 0x04009056 RID: 36950
	private VisionRecommendFetterItem FetterItem;

	// Token: 0x04009057 RID: 36951
	private RecommendSkillBranchItem SkillBranchItem;

	// Token: 0x04009058 RID: 36952
	private int RoleId;

	// Token: 0x04009059 RID: 36953
	private VisionFetterRecommendInfo Data;

	// Token: 0x02007C08 RID: 31752
	[NullableContext(0)]
	private enum EComp
	{
		// Token: 0x040282B9 RID: 164537
		Toggle,
		// Token: 0x040282BA RID: 164538
		SkillBranchRoot,
		// Token: 0x040282BB RID: 164539
		SkillBranchItem
	}
}
