using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Game.Module.Activity.ActivityContent.Encircle;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001CFE RID: 7422
[NullableContext(2)]
[Nullable(0)]
public class RoleTowerRolePropertyView : UiViewBase
{
	// Token: 0x06012603 RID: 75267 RVA: 0x0056D5D3 File Offset: 0x0056B7D3
	[NullableContext(1)]
	public RoleTowerRolePropertyView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x17001B73 RID: 7027
	// (get) Token: 0x06012604 RID: 75268 RVA: 0x0056D5DC File Offset: 0x0056B7DC
	private new RoleTowerRolePropertyViewParams OpenParam
	{
		get
		{
			return this.OpenParam as RoleTowerRolePropertyViewParams;
		}
	}

	// Token: 0x06012605 RID: 75269 RVA: 0x0056D5EC File Offset: 0x0056B7EC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(USpineSkeletonAnimationComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
	}

	// Token: 0x06012606 RID: 75270 RVA: 0x0056D674 File Offset: 0x0056B874
	protected override UniTask OnBeforeStartAsync()
	{
		RoleTowerRolePropertyView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleTowerRolePropertyView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012607 RID: 75271 RVA: 0x0056D6B8 File Offset: 0x0056B8B8
	protected override void OnStart()
	{
		RoleTowerRolePropertyViewParams openParam = this.OpenParam;
		this.CurTab = ((openParam != null) ? openParam.Tab : ERoleTowerStarEchoTab.Star);
		RoleTowerRolePropertyViewParams openParam2 = this.OpenParam;
		int curRoleId;
		if (openParam2 != null && openParam2.RoleId == 0)
		{
			curRoleId = RoleTowerModel.Instance.GetDefaultSelectSlotRoleId();
		}
		else
		{
			RoleTowerRolePropertyViewParams openParam3 = this.OpenParam;
			curRoleId = ((openParam3 != null) ? openParam3.RoleId : 0);
		}
		this.CurRoleId = curRoleId;
		this.NeedRequestRoleAttrs = true;
	}

	// Token: 0x06012608 RID: 75272 RVA: 0x0056D71F File Offset: 0x0056B91F
	protected override void OnBeforeShow()
	{
		this.RefreshAll();
	}

	// Token: 0x06012609 RID: 75273 RVA: 0x0056D728 File Offset: 0x0056B928
	protected override UniTask OnBeforeShowAsyncImplementImplement()
	{
		RoleTowerRolePropertyView.<OnBeforeShowAsyncImplementImplement>d__17 <OnBeforeShowAsyncImplementImplement>d__;
		<OnBeforeShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplementImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplementImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Start<RoleTowerRolePropertyView.<OnBeforeShowAsyncImplementImplement>d__17>(ref <OnBeforeShowAsyncImplementImplement>d__);
		return <OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Task;
	}

	// Token: 0x0601260A RID: 75274 RVA: 0x0056D76C File Offset: 0x0056B96C
	private void RefreshAll()
	{
		this.RefreshRolePix();
		RoleTowerPropLeftPanel leftPanel = this.LeftPanel;
		if (leftPanel != null)
		{
			leftPanel.Refresh(this.CurTab, this.CurRoleId);
		}
		RoleTowerPropRightPanel rightPanel = this.RightPanel;
		if (rightPanel == null)
		{
			return;
		}
		rightPanel.Refresh(this.CurTab, this.CurRoleId);
	}

	// Token: 0x0601260B RID: 75275 RVA: 0x0056D7B8 File Offset: 0x0056B9B8
	private void RefreshRolePix()
	{
		RoleTowerRolePropertyView.<>c__DisplayClass19_0 CS$<>8__locals1 = new RoleTowerRolePropertyView.<>c__DisplayClass19_0();
		CS$<>8__locals1.<>4__this = this;
		if (this.CurRoleId <= 0)
		{
			return;
		}
		CS$<>8__locals1.spine = base.GetSpine(1);
		RoleTowerRolePropertyView.<>c__DisplayClass19_0 CS$<>8__locals2 = CS$<>8__locals1;
		USpineSkeletonAnimationComponent spine = CS$<>8__locals1.spine;
		object obj;
		if (spine == null)
		{
			obj = null;
		}
		else
		{
			AActor owner = spine.GetOwner();
			obj = ((owner != null) ? owner.GetComponentByClass(UUIItem.StaticClass()) : null);
		}
		CS$<>8__locals2.roleItem = (obj as UUIItem);
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(this.CurRoleId);
		if (CS$<>8__locals1.spine == null || CS$<>8__locals1.roleItem == null || roleConfig == null)
		{
			return;
		}
		if (this.CurRoleId == this.RolePixRoleId)
		{
			return;
		}
		this.RolePixRoleId = this.CurRoleId;
		RoleTowerRolePropertyView.<>c__DisplayClass19_0 CS$<>8__locals3 = CS$<>8__locals1;
		int num = this.RolePixRefreshToken + 1;
		this.RolePixRefreshToken = num;
		CS$<>8__locals3.refreshToken = num;
		RoleSkin? roleSkinConfig = SkinConfig.Instance.GetRoleSkinConfig(roleConfig.Value.SkinId);
		if (roleSkinConfig == null || string.IsNullOrEmpty(roleSkinConfig.Value.FormationSpineAtlas) || string.IsNullOrEmpty(roleSkinConfig.Value.FormationSpineSkeletonData))
		{
			CS$<>8__locals1.roleItem.SetUIActive(false);
			return;
		}
		CS$<>8__locals1.param = roleSkinConfig.Value.GetSpineParamArray();
		CS$<>8__locals1.roleItem.SetUIActive(false);
		base.SetSpineAssetByPath(roleSkinConfig.Value.FormationSpineAtlas, roleSkinConfig.Value.FormationSpineSkeletonData, CS$<>8__locals1.spine).ContinueWith(delegate()
		{
			if (CS$<>8__locals1.refreshToken != CS$<>8__locals1.<>4__this.RolePixRefreshToken)
			{
				return;
			}
			if (CS$<>8__locals1.param.Length >= 3)
			{
				CS$<>8__locals1.roleItem.SetAnchorOffsetX(CS$<>8__locals1.param[0]);
				CS$<>8__locals1.roleItem.SetAnchorOffsetY(CS$<>8__locals1.param[1]);
				CS$<>8__locals1.roleItem.SetUIItemScale(new FVector(CS$<>8__locals1.param[2], CS$<>8__locals1.param[2], CS$<>8__locals1.param[2]));
			}
			CS$<>8__locals1.roleItem.SetUIActive(true);
			CS$<>8__locals1.spine.SetAnimation(0, ESpineAnimation.Idle.ToEnumString(), true);
		});
	}

	// Token: 0x0601260C RID: 75276 RVA: 0x0056D938 File Offset: 0x0056BB38
	private void OnBriefDescToggleChanged(EToggleState state)
	{
		RoleTowerModel.Instance.IsShowBriefDesc = (state == EToggleState.ETT_Checked);
		RoleTowerPropLeftPanel leftPanel = this.LeftPanel;
		if (leftPanel == null)
		{
			return;
		}
		leftPanel.Refresh(this.CurTab, this.CurRoleId);
	}

	// Token: 0x0601260D RID: 75277 RVA: 0x0056D964 File Offset: 0x0056BB64
	private void OnSwitchTab(ERoleTowerStarEchoTab tab)
	{
		bool flag = this.CurTab != tab;
		this.CurTab = tab;
		this.RefreshAll();
		if (flag)
		{
			base.PlaySequence("SwitchA", null, false);
			if (tab == ERoleTowerStarEchoTab.Echo)
			{
				EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "RoleTowerRolePropertyViewPhantomTab");
			}
		}
	}

	// Token: 0x0601260E RID: 75278 RVA: 0x0056D9B2 File Offset: 0x0056BBB2
	private void OnSwitchRole(int roleId)
	{
		bool flag = this.CurRoleId != roleId;
		this.CurRoleId = roleId;
		this.RefreshAll();
		if (flag)
		{
			base.PlaySequence("Switch", null, false);
		}
		this.RequestRoleAttrsAsync(roleId);
	}

	// Token: 0x0601260F RID: 75279 RVA: 0x0056D9E4 File Offset: 0x0056BBE4
	private UniTask RequestRoleAttrsAsync(int roleId)
	{
		RoleTowerRolePropertyView.<RequestRoleAttrsAsync>d__23 <RequestRoleAttrsAsync>d__;
		<RequestRoleAttrsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestRoleAttrsAsync>d__.<>4__this = this;
		<RequestRoleAttrsAsync>d__.roleId = roleId;
		<RequestRoleAttrsAsync>d__.<>1__state = -1;
		<RequestRoleAttrsAsync>d__.<>t__builder.Start<RoleTowerRolePropertyView.<RequestRoleAttrsAsync>d__23>(ref <RequestRoleAttrsAsync>d__);
		return <RequestRoleAttrsAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0400A021 RID: 40993
	private PopupCaptionItem Caption;

	// Token: 0x0400A022 RID: 40994
	private PopupCaptionToggleItem BriefDescToggle;

	// Token: 0x0400A023 RID: 40995
	private RoleTowerPropLeftPanel LeftPanel;

	// Token: 0x0400A024 RID: 40996
	private RoleTowerPropRightPanel RightPanel;

	// Token: 0x0400A025 RID: 40997
	private ERoleTowerStarEchoTab CurTab;

	// Token: 0x0400A026 RID: 40998
	private int CurRoleId;

	// Token: 0x0400A027 RID: 40999
	private bool NeedRequestRoleAttrs;

	// Token: 0x0400A028 RID: 41000
	private int RolePixRefreshToken;

	// Token: 0x0400A029 RID: 41001
	private int RolePixRoleId;

	// Token: 0x02008022 RID: 32802
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x04029759 RID: 169817
		public const int UiItemCaption = 0;

		// Token: 0x0402975A RID: 169818
		public const int SpineRolePix = 1;

		// Token: 0x0402975B RID: 169819
		public const int PnlLeft = 2;

		// Token: 0x0402975C RID: 169820
		public const int PnlRight = 3;

		// Token: 0x0402975D RID: 169821
		public const int TogBriefDesc = 4;
	}
}
