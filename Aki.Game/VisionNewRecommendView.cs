using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020024E7 RID: 9447
[NullableContext(2)]
[Nullable(0)]
public class VisionNewRecommendView : UiViewBase
{
	// Token: 0x06012FF2 RID: 77810 RVA: 0x004B46C3 File Offset: 0x004B28C3
	[NullableContext(1)]
	public VisionNewRecommendView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06012FF3 RID: 77811 RVA: 0x004B46CC File Offset: 0x004B28CC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnClickSimpleToggle))
		};
	}

	// Token: 0x06012FF4 RID: 77812 RVA: 0x004B4778 File Offset: 0x004B2978
	protected override UniTask OnBeforeStartAsync()
	{
		VisionNewRecommendView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionNewRecommendView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012FF5 RID: 77813 RVA: 0x004B47BB File Offset: 0x004B29BB
	private void InitProxy()
	{
		this.Proxy = new VisionNewRecommendProxy();
		this.Proxy.MainViewSequence = this.UiViewSequence;
	}

	// Token: 0x06012FF6 RID: 77814 RVA: 0x004B47DC File Offset: 0x004B29DC
	private void InitButton()
	{
		this.Button = new ButtonItem(base.GetItem(4));
		if ((this.OpenParam as IVisionRecommendViewOpenParam).IsFromRoleDev)
		{
			this.Button.TrySetLocalTextNew("PhantomRecommend_Button05", Array.Empty<object>());
			this.Button.SetFunction(new Action<int>(this.OnClickChangeBtn));
			return;
		}
		this.Button.TrySetLocalTextNew("PhantomRecommend_Button03", Array.Empty<object>());
		this.Button.SetFunction(new Action<int>(this.OnClickPreviewBtn));
	}

	// Token: 0x06012FF7 RID: 77815 RVA: 0x004B4868 File Offset: 0x004B2A68
	private void OnClickChangeBtn(int _)
	{
		Action<int, int, int?> onChangeFetterGroupSuccessCallBack = this.OnChangeFetterGroupSuccessCallBack;
		if (onChangeFetterGroupSuccessCallBack != null)
		{
			onChangeFetterGroupSuccessCallBack(this.Proxy.CurrentSelectRoleId, this.Proxy.CurrentSelectFetterRecommendInfo.GetPlanId(), new int?(this.Proxy.CurrentSelectFirstVisionMonsterId));
		}
		base.CloseMe(null);
	}

	// Token: 0x06012FF8 RID: 77816 RVA: 0x004B48B8 File Offset: 0x004B2AB8
	private void InitCaptionItem()
	{
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetCloseCallBack(new Action(this.CloseCallBack));
		this.CaptionItem.SetTitleLocalText("PrefabTextItem_PhantomRecommend_Text");
	}

	// Token: 0x06012FF9 RID: 77817 RVA: 0x004B48F4 File Offset: 0x004B2AF4
	private UniTask InitLeftPanelView()
	{
		VisionNewRecommendView.<InitLeftPanelView>d__14 <InitLeftPanelView>d__;
		<InitLeftPanelView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitLeftPanelView>d__.<>4__this = this;
		<InitLeftPanelView>d__.<>1__state = -1;
		<InitLeftPanelView>d__.<>t__builder.Start<VisionNewRecommendView.<InitLeftPanelView>d__14>(ref <InitLeftPanelView>d__);
		return <InitLeftPanelView>d__.<>t__builder.Task;
	}

	// Token: 0x06012FFA RID: 77818 RVA: 0x004B4938 File Offset: 0x004B2B38
	private UniTask InitRightPanelView()
	{
		VisionNewRecommendView.<InitRightPanelView>d__15 <InitRightPanelView>d__;
		<InitRightPanelView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRightPanelView>d__.<>4__this = this;
		<InitRightPanelView>d__.<>1__state = -1;
		<InitRightPanelView>d__.<>t__builder.Start<VisionNewRecommendView.<InitRightPanelView>d__15>(ref <InitRightPanelView>d__);
		return <InitRightPanelView>d__.<>t__builder.Task;
	}

	// Token: 0x06012FFB RID: 77819 RVA: 0x004B497B File Offset: 0x004B2B7B
	private void CloseCallBack()
	{
		base.CloseMe(null);
	}

	// Token: 0x06012FFC RID: 77820 RVA: 0x004B4984 File Offset: 0x004B2B84
	protected override void OnHandleReleaseScene()
	{
		this.TryHideUiRoleModel();
	}

	// Token: 0x06012FFD RID: 77821 RVA: 0x004B498C File Offset: 0x004B2B8C
	private void TryHideUiRoleModel()
	{
		TsUiSceneRoleActor roleSystemRoleActor = UiSceneManager.Instance.GetRoleSystemRoleActor();
		if (roleSystemRoleActor == null)
		{
			return;
		}
		UiModelBase model = roleSystemRoleActor.Model;
		UiModelUtil.Instance.StopFade(model);
		UiModelUtil.Instance.SetDitherEffect(model, 0f);
		UiModelUtil.Instance.SetVisible(model, false);
	}

	// Token: 0x06012FFE RID: 77822 RVA: 0x004B49D7 File Offset: 0x004B2BD7
	protected override void OnBeforeShow()
	{
		this.TryHideUiRoleModel();
	}

	// Token: 0x06012FFF RID: 77823 RVA: 0x004B49DF File Offset: 0x004B2BDF
	protected override void OnStart()
	{
		this.RefreshSimpleToggleState();
	}

	// Token: 0x06013000 RID: 77824 RVA: 0x004B49E8 File Offset: 0x004B2BE8
	private void RefreshSimpleToggleState()
	{
		EToggleState state = this.Proxy.IsSimpleMode ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		UUIExtendToggle extendToggle = base.GetExtendToggle(1);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(state, false, false, true);
	}

	// Token: 0x06013001 RID: 77825 RVA: 0x004B4A20 File Offset: 0x004B2C20
	private void InitOpenParam()
	{
		IVisionRecommendViewOpenParam visionRecommendViewOpenParam = this.OpenParam as IVisionRecommendViewOpenParam;
		this.OnChangeFetterGroupSuccessCallBack = visionRecommendViewOpenParam.SuccessCallBack;
		this.Proxy.GetSelectedPlanIdCallBack = visionRecommendViewOpenParam.GetSelectedPlanIdCallBack;
		this.Proxy.GetSelectedFirstVisionMonsterIdCallBack = visionRecommendViewOpenParam.GetSelectedFirstVisionMonsterIdCallBack;
		this.Proxy.IsFromRoleDev = visionRecommendViewOpenParam.IsFromRoleDev;
	}

	// Token: 0x06013002 RID: 77826 RVA: 0x004B4A78 File Offset: 0x004B2C78
	private void OnClickGuideBtn()
	{
		bool showFastFilter = RoleModel.Instance.IsRoleOwned(this.Proxy.CurrentSelectRoleId);
		PhantomBattleController.Instance.OpenPhantomBattleFetterView(this.Proxy.CurrentSelectFetterRecommendInfo.GetRecommendFetterGroupId(), this.Proxy.CurrentSelectRoleId, showFastFilter, this.Proxy.CurrentSelectFetterRecommendInfo.BuildFetterList()).Forget();
	}

	// Token: 0x06013003 RID: 77827 RVA: 0x004B4AD6 File Offset: 0x004B2CD6
	private void OnClickTrackBtn()
	{
		CalabashController.Instance.JumpToCalabashCollectTabView(this.Proxy.CurrentSelectFirstVisionMonsterId);
	}

	// Token: 0x06013004 RID: 77828 RVA: 0x004B4AF0 File Offset: 0x004B2CF0
	private void OnClickPreviewBtn(int _)
	{
		VisionNewRecommendPreviewViewOpenParam param = new VisionNewRecommendPreviewViewOpenParam
		{
			Proxy = this.Proxy,
			OnApplySuccess = delegate
			{
				base.CloseMe(null);
			}
		};
		UiManager.Instance.OpenView(EUiViewName.VisionNewRecommendPreviewView, param, null);
	}

	// Token: 0x06013005 RID: 77829 RVA: 0x004B4B32 File Offset: 0x004B2D32
	private void OnClickSimpleToggle(EToggleState _)
	{
		VisionNewRecommendProxy proxy = this.Proxy;
		UUIExtendToggle extendToggle = base.GetExtendToggle(1);
		proxy.IsSimpleMode = (extendToggle != null && extendToggle.GetToggleState() == EToggleState.ETT_Checked);
		VisionNewRecommendRightPanelView rightPanelView = this.RightPanelView;
		if (rightPanelView == null)
		{
			return;
		}
		rightPanelView.RefreshSimpleMode();
	}

	// Token: 0x04008EFB RID: 36603
	private PopupCaptionItem CaptionItem;

	// Token: 0x04008EFC RID: 36604
	private VisionNewRecommendProxy Proxy;

	// Token: 0x04008EFD RID: 36605
	private VisionNewRecommendLeftPanelView LeftPanelView;

	// Token: 0x04008EFE RID: 36606
	private VisionNewRecommendRightPanelView RightPanelView;

	// Token: 0x04008EFF RID: 36607
	private ButtonItem Button;

	// Token: 0x04008F00 RID: 36608
	private Action<int, int, int?> OnChangeFetterGroupSuccessCallBack;

	// Token: 0x02008A78 RID: 35448
	[NullableContext(0)]
	private enum EComp
	{
		// Token: 0x0402CF6F RID: 184175
		CaptionItem,
		// Token: 0x0402CF70 RID: 184176
		SimpleToggle,
		// Token: 0x0402CF71 RID: 184177
		PnlLeft,
		// Token: 0x0402CF72 RID: 184178
		PnlRight,
		// Token: 0x0402CF73 RID: 184179
		Button
	}
}
