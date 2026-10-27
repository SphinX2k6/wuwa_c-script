using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020024DD RID: 9437
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class VisionNewRecommendBranchFetterItem : GridProxyAbstract<VisionFetterRecommendInfo>
{
	// Token: 0x06012FA7 RID: 77735 RVA: 0x004B3238 File Offset: 0x004B1438
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick))
		};
	}

	// Token: 0x06012FA8 RID: 77736 RVA: 0x004B32CC File Offset: 0x004B14CC
	protected override UniTask OnBeforeStartAsync()
	{
		VisionNewRecommendBranchFetterItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionNewRecommendBranchFetterItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012FA9 RID: 77737 RVA: 0x004B3310 File Offset: 0x004B1510
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
		extendToggle.bLockStateOnSelect = true;
		this.FetterItem = new VisionNewRecommendFetterItem();
		this.FetterItem.CreateThenShowByActor(base.GetExtendToggle(0).GetOwner());
	}

	// Token: 0x06012FAA RID: 77738 RVA: 0x004B335D File Offset: 0x004B155D
	[NullableContext(1)]
	public override void Refresh(VisionFetterRecommendInfo data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.FetterItem.Refresh(data, isSelected, gridIndex);
		this.RefreshSkillBranchItem();
	}

	// Token: 0x06012FAB RID: 77739 RVA: 0x004B337C File Offset: 0x004B157C
	public void RefreshSkillBranchItem()
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
		PhantomPlanParam? config2 = ConfigPhantomPlanParamById.GetConfig(config.Value.PhantomPlanParamId(num.Value), true);
		int skillBranchId = config2.Value.SkillBranchId;
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
		if (skillBranchItem2 != null)
		{
			skillBranchItem2.RefreshIcon(new Func<int, string>(this.RefreshSkillBranchIconHandler));
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), config2.Value.SkillBranchText, Array.Empty<object>());
	}

	// Token: 0x06012FAC RID: 77740 RVA: 0x004B3536 File Offset: 0x004B1736
	public void SetRoldId(int roleId)
	{
		this.RoleId = roleId;
	}

	// Token: 0x06012FAD RID: 77741 RVA: 0x004B3540 File Offset: 0x004B1740
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

	// Token: 0x06012FAE RID: 77742 RVA: 0x004B3589 File Offset: 0x004B1789
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

	// Token: 0x06012FAF RID: 77743 RVA: 0x004B35A5 File Offset: 0x004B17A5
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true, fireEvent);
	}

	// Token: 0x06012FB0 RID: 77744 RVA: 0x004B35AF File Offset: 0x004B17AF
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false, fireEvent);
	}

	// Token: 0x06012FB1 RID: 77745 RVA: 0x004B35B9 File Offset: 0x004B17B9
	private void SetToggleState(bool isSelected, bool fireEvent = false)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x06012FB2 RID: 77746 RVA: 0x004B35D6 File Offset: 0x004B17D6
	[NullableContext(1)]
	public override object GetKey(VisionFetterRecommendInfo data, int displayIndex)
	{
		return data.GetPlanId();
	}

	// Token: 0x04008EDC RID: 36572
	private VisionNewRecommendFetterItem FetterItem;

	// Token: 0x04008EDD RID: 36573
	private RecommendSkillBranchItem SkillBranchItem;

	// Token: 0x04008EDE RID: 36574
	private int RoleId;

	// Token: 0x04008EDF RID: 36575
	private VisionFetterRecommendInfo Data;

	// Token: 0x04008EE0 RID: 36576
	public Action<int> OnSelectedCallback;

	// Token: 0x02008A6E RID: 35438
	[NullableContext(0)]
	private enum EComp
	{
		// Token: 0x0402CF3B RID: 184123
		Toggle,
		// Token: 0x0402CF3C RID: 184124
		SkillBranchRoot,
		// Token: 0x0402CF3D RID: 184125
		SkillBranchItem,
		// Token: 0x0402CF3E RID: 184126
		SkillBranchText
	}
}
