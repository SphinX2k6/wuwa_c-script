using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020019C4 RID: 6596
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class VisionNewRecommendBranchFetterItem : GridProxyAbstract<VisionFetterRecommendInfo>
{
	// Token: 0x06010466 RID: 66662 RVA: 0x004C0DF8 File Offset: 0x004BEFF8
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

	// Token: 0x06010467 RID: 66663 RVA: 0x004C0E8C File Offset: 0x004BF08C
	protected override UniTask OnBeforeStartAsync()
	{
		VisionNewRecommendBranchFetterItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionNewRecommendBranchFetterItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010468 RID: 66664 RVA: 0x004C0ED0 File Offset: 0x004BF0D0
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

	// Token: 0x06010469 RID: 66665 RVA: 0x004C0F1D File Offset: 0x004BF11D
	[NullableContext(1)]
	public override void Refresh(VisionFetterRecommendInfo data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.FetterItem.Refresh(data, isSelected, gridIndex);
		this.RefreshSkillBranchItem();
	}

	// Token: 0x0601046A RID: 66666 RVA: 0x004C0F3C File Offset: 0x004BF13C
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

	// Token: 0x0601046B RID: 66667 RVA: 0x004C10F6 File Offset: 0x004BF2F6
	public void SetRoldId(int roleId)
	{
		this.RoleId = roleId;
	}

	// Token: 0x0601046C RID: 66668 RVA: 0x004C1100 File Offset: 0x004BF300
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

	// Token: 0x0601046D RID: 66669 RVA: 0x004C1149 File Offset: 0x004BF349
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

	// Token: 0x0601046E RID: 66670 RVA: 0x004C1165 File Offset: 0x004BF365
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true, fireEvent);
	}

	// Token: 0x0601046F RID: 66671 RVA: 0x004C116F File Offset: 0x004BF36F
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false, fireEvent);
	}

	// Token: 0x06010470 RID: 66672 RVA: 0x004C1179 File Offset: 0x004BF379
	private void SetToggleState(bool isSelected, bool fireEvent = false)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x06010471 RID: 66673 RVA: 0x004C1196 File Offset: 0x004BF396
	[NullableContext(1)]
	public override object GetKey(VisionFetterRecommendInfo data, int displayIndex)
	{
		return data.GetPlanId();
	}

	// Token: 0x04009026 RID: 36902
	private VisionNewRecommendFetterItem FetterItem;

	// Token: 0x04009027 RID: 36903
	private RecommendSkillBranchItem SkillBranchItem;

	// Token: 0x04009028 RID: 36904
	private int RoleId;

	// Token: 0x04009029 RID: 36905
	private VisionFetterRecommendInfo Data;

	// Token: 0x0400902A RID: 36906
	public Action<int> OnSelectedCallback;

	// Token: 0x02007BF6 RID: 31734
	[NullableContext(0)]
	private enum EComp
	{
		// Token: 0x04028254 RID: 164436
		Toggle,
		// Token: 0x04028255 RID: 164437
		SkillBranchRoot,
		// Token: 0x04028256 RID: 164438
		SkillBranchItem,
		// Token: 0x04028257 RID: 164439
		SkillBranchText
	}
}
