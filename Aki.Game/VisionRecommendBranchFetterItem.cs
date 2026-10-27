using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020024EB RID: 9451
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class VisionRecommendBranchFetterItem : GridProxyAbstract<VisionFetterRecommendInfo>
{
	// Token: 0x06013018 RID: 77848 RVA: 0x004B5014 File Offset: 0x004B3214
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

	// Token: 0x06013019 RID: 77849 RVA: 0x004B5094 File Offset: 0x004B3294
	protected override UniTask OnBeforeStartAsync()
	{
		VisionRecommendBranchFetterItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionRecommendBranchFetterItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601301A RID: 77850 RVA: 0x004B50D7 File Offset: 0x004B32D7
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
		extendToggle.bLockStateOnSelect = true;
	}

	// Token: 0x0601301B RID: 77851 RVA: 0x004B50F7 File Offset: 0x004B32F7
	[NullableContext(1)]
	public override void Refresh(VisionFetterRecommendInfo data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.FetterItem.Refresh(data, isSelected, gridIndex);
		this.RefreshSkillBranchItem();
	}

	// Token: 0x0601301C RID: 77852 RVA: 0x004B5114 File Offset: 0x004B3314
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

	// Token: 0x0601301D RID: 77853 RVA: 0x004B52A7 File Offset: 0x004B34A7
	public void SetRoldId(int roleId)
	{
		this.RoleId = roleId;
	}

	// Token: 0x0601301E RID: 77854 RVA: 0x004B52B0 File Offset: 0x004B34B0
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

	// Token: 0x0601301F RID: 77855 RVA: 0x004B52F9 File Offset: 0x004B34F9
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

	// Token: 0x06013020 RID: 77856 RVA: 0x004B5315 File Offset: 0x004B3515
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true, fireEvent);
	}

	// Token: 0x06013021 RID: 77857 RVA: 0x004B531F File Offset: 0x004B351F
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false, fireEvent);
	}

	// Token: 0x06013022 RID: 77858 RVA: 0x004B5329 File Offset: 0x004B3529
	private void SetToggleState(bool isSelected, bool fireEvent = false)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x06013023 RID: 77859 RVA: 0x004B5346 File Offset: 0x004B3546
	[NullableContext(1)]
	public override object GetKey(VisionFetterRecommendInfo data, int displayIndex)
	{
		return data;
	}

	// Token: 0x04008F0B RID: 36619
	public Action<int> OnSelectedCallback;

	// Token: 0x04008F0C RID: 36620
	private VisionRecommendFetterItem FetterItem;

	// Token: 0x04008F0D RID: 36621
	private RecommendSkillBranchItem SkillBranchItem;

	// Token: 0x04008F0E RID: 36622
	private int RoleId;

	// Token: 0x04008F0F RID: 36623
	private VisionFetterRecommendInfo Data;

	// Token: 0x02008A80 RID: 35456
	[NullableContext(0)]
	private enum EComp
	{
		// Token: 0x0402CFA1 RID: 184225
		Toggle,
		// Token: 0x0402CFA2 RID: 184226
		SkillBranchRoot,
		// Token: 0x0402CFA3 RID: 184227
		SkillBranchItem
	}
}
