using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020019CE RID: 6606
[NullableContext(2)]
[Nullable(0)]
public class VisionNewRecommendView : UiViewBase
{
	// Token: 0x060104B1 RID: 66737 RVA: 0x004C236F File Offset: 0x004C056F
	[NullableContext(1)]
	public VisionNewRecommendView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060104B2 RID: 66738 RVA: 0x004C2378 File Offset: 0x004C0578
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

	// Token: 0x060104B3 RID: 66739 RVA: 0x004C2424 File Offset: 0x004C0624
	protected override UniTask OnBeforeStartAsync()
	{
		VisionNewRecommendView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionNewRecommendView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060104B4 RID: 66740 RVA: 0x004C2467 File Offset: 0x004C0667
	private void InitProxy()
	{
		this.Proxy = new VisionNewRecommendProxy();
		this.Proxy.MainViewSequence = this.UiViewSequence;
	}

	// Token: 0x060104B5 RID: 66741 RVA: 0x004C2488 File Offset: 0x004C0688
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

	// Token: 0x060104B6 RID: 66742 RVA: 0x004C2514 File Offset: 0x004C0714
	private void OnClickChangeBtn(int _)
	{
		Action<int, int, int?> onChangeFetterGroupSuccessCallBack = this.OnChangeFetterGroupSuccessCallBack;
		if (onChangeFetterGroupSuccessCallBack != null)
		{
			onChangeFetterGroupSuccessCallBack(this.Proxy.CurrentSelectRoleId, this.Proxy.CurrentSelectFetterRecommendInfo.GetPlanId(), new int?(this.Proxy.CurrentSelectFirstVisionMonsterId));
		}
		base.CloseMe(null);
	}

	// Token: 0x060104B7 RID: 66743 RVA: 0x004C2564 File Offset: 0x004C0764
	private void InitCaptionItem()
	{
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetCloseCallBack(new Action(this.CloseCallBack));
		this.CaptionItem.SetTitleLocalText("PrefabTextItem_PhantomRecommend_Text");
	}

	// Token: 0x060104B8 RID: 66744 RVA: 0x004C25A0 File Offset: 0x004C07A0
	private UniTask InitLeftPanelView()
	{
		VisionNewRecommendView.<InitLeftPanelView>d__14 <InitLeftPanelView>d__;
		<InitLeftPanelView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitLeftPanelView>d__.<>4__this = this;
		<InitLeftPanelView>d__.<>1__state = -1;
		<InitLeftPanelView>d__.<>t__builder.Start<VisionNewRecommendView.<InitLeftPanelView>d__14>(ref <InitLeftPanelView>d__);
		return <InitLeftPanelView>d__.<>t__builder.Task;
	}

	// Token: 0x060104B9 RID: 66745 RVA: 0x004C25E4 File Offset: 0x004C07E4
	private UniTask InitRightPanelView()
	{
		VisionNewRecommendView.<InitRightPanelView>d__15 <InitRightPanelView>d__;
		<InitRightPanelView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRightPanelView>d__.<>4__this = this;
		<InitRightPanelView>d__.<>1__state = -1;
		<InitRightPanelView>d__.<>t__builder.Start<VisionNewRecommendView.<InitRightPanelView>d__15>(ref <InitRightPanelView>d__);
		return <InitRightPanelView>d__.<>t__builder.Task;
	}

	// Token: 0x060104BA RID: 66746 RVA: 0x004C2627 File Offset: 0x004C0827
	private void CloseCallBack()
	{
		base.CloseMe(null);
	}

	// Token: 0x060104BB RID: 66747 RVA: 0x004C2630 File Offset: 0x004C0830
	protected override void OnHandleReleaseScene()
	{
		this.TryHideUiRoleModel();
	}

	// Token: 0x060104BC RID: 66748 RVA: 0x004C2638 File Offset: 0x004C0838
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

	// Token: 0x060104BD RID: 66749 RVA: 0x004C2683 File Offset: 0x004C0883
	protected override void OnBeforeShow()
	{
		this.TryHideUiRoleModel();
	}

	// Token: 0x060104BE RID: 66750 RVA: 0x004C268B File Offset: 0x004C088B
	protected override void OnStart()
	{
		this.RefreshSimpleToggleState();
	}

	// Token: 0x060104BF RID: 66751 RVA: 0x004C2694 File Offset: 0x004C0894
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

	// Token: 0x060104C0 RID: 66752 RVA: 0x004C26CC File Offset: 0x004C08CC
	private void InitOpenParam()
	{
		IVisionRecommendViewOpenParam visionRecommendViewOpenParam = this.OpenParam as IVisionRecommendViewOpenParam;
		this.OnChangeFetterGroupSuccessCallBack = visionRecommendViewOpenParam.SuccessCallBack;
		this.Proxy.GetSelectedPlanIdCallBack = visionRecommendViewOpenParam.GetSelectedPlanIdCallBack;
		this.Proxy.GetSelectedFirstVisionMonsterIdCallBack = visionRecommendViewOpenParam.GetSelectedFirstVisionMonsterIdCallBack;
		this.Proxy.IsFromRoleDev = visionRecommendViewOpenParam.IsFromRoleDev;
	}

	// Token: 0x060104C1 RID: 66753 RVA: 0x004C2724 File Offset: 0x004C0924
	private void OnClickGuideBtn()
	{
		bool showFastFilter = RoleModel.Instance.IsRoleOwned(this.Proxy.CurrentSelectRoleId);
		PhantomBattleController.Instance.OpenPhantomBattleFetterView(this.Proxy.CurrentSelectFetterRecommendInfo.GetRecommendFetterGroupId(), this.Proxy.CurrentSelectRoleId, showFastFilter, this.Proxy.CurrentSelectFetterRecommendInfo.BuildFetterList()).Forget();
	}

	// Token: 0x060104C2 RID: 66754 RVA: 0x004C2782 File Offset: 0x004C0982
	private void OnClickTrackBtn()
	{
		CalabashController.Instance.JumpToCalabashCollectTabView(this.Proxy.CurrentSelectFirstVisionMonsterId);
	}

	// Token: 0x060104C3 RID: 66755 RVA: 0x004C279C File Offset: 0x004C099C
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

	// Token: 0x060104C4 RID: 66756 RVA: 0x004C27DE File Offset: 0x004C09DE
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

	// Token: 0x04009045 RID: 36933
	private PopupCaptionItem CaptionItem;

	// Token: 0x04009046 RID: 36934
	private VisionNewRecommendProxy Proxy;

	// Token: 0x04009047 RID: 36935
	private VisionNewRecommendLeftPanelView LeftPanelView;

	// Token: 0x04009048 RID: 36936
	private VisionNewRecommendRightPanelView RightPanelView;

	// Token: 0x04009049 RID: 36937
	private ButtonItem Button;

	// Token: 0x0400904A RID: 36938
	private Action<int, int, int?> OnChangeFetterGroupSuccessCallBack;

	// Token: 0x02007C00 RID: 31744
	[NullableContext(0)]
	private enum EComp
	{
		// Token: 0x04028287 RID: 164487
		CaptionItem,
		// Token: 0x04028288 RID: 164488
		SimpleToggle,
		// Token: 0x04028289 RID: 164489
		PnlLeft,
		// Token: 0x0402828A RID: 164490
		PnlRight,
		// Token: 0x0402828B RID: 164491
		Button
	}
}
