using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001E5B RID: 7771
[NullableContext(1)]
[Nullable(0)]
public class HelpGuideView : UiViewBase
{
	// Token: 0x0600EC2A RID: 60458 RVA: 0x00381051 File Offset: 0x0037F251
	public HelpGuideView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600EC2B RID: 60459 RVA: 0x00381068 File Offset: 0x0037F268
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(14, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action(this.OnCloseClick)),
			new ValueTuple<int, Delegate>(13, new Action(this.OnCloseClick)),
			new ValueTuple<int, Delegate>(7, new Action(this.PrePage)),
			new ValueTuple<int, Delegate>(8, new Action(this.NextPage))
		};
	}

	// Token: 0x0600EC2C RID: 60460 RVA: 0x0038123C File Offset: 0x0037F43C
	private void OnCloseClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600EC2D RID: 60461 RVA: 0x00381248 File Offset: 0x0037F448
	private void PrePage()
	{
		if (this.MoveTween == null && this.NowPage > 0)
		{
			UUIItem rootItem = this.CurrentShowPanel.GetRootItem();
			FVector relativeLocation = rootItem.RelativeLocation;
			UUIItem item = base.GetItem(12);
			item.SetUIRelativeLocation(new FVector(-item.Width, item.RelativeLocation.Y, item.RelativeLocation.Z));
			this.SwitchPanelAnim();
			this.LastShowPanel.GetRootItem().SetUIRelativeLocation(new FVector(rootItem.Width, relativeLocation.Y, relativeLocation.Z));
			this.RefreshView(this.NowPage - 1);
			this.MoveTween = ULTweenBPLibrary.LocalPositionXTo(item, 0f, 0.3f, 0f, LTweenEase.InOutCubic);
			this.MoveTween.OnCompleteCallBack.Bind(delegate()
			{
				this.MoveTween = null;
			});
		}
	}

	// Token: 0x0600EC2E RID: 60462 RVA: 0x00381324 File Offset: 0x0037F524
	private void NextPage()
	{
		if (this.MoveTween == null && this.NowPage < this.PageArray.Count - 1)
		{
			UUIItem rootItem = this.CurrentShowPanel.GetRootItem();
			FVector relativeLocation = rootItem.RelativeLocation;
			UUIItem item = base.GetItem(12);
			item.SetUIRelativeLocation(new FVector(item.Width, item.RelativeLocation.Y, item.RelativeLocation.Z));
			this.SwitchPanelAnim();
			this.LastShowPanel.GetRootItem().SetUIRelativeLocation(new FVector(-rootItem.Width, relativeLocation.Y, relativeLocation.Z));
			this.RefreshView(this.NowPage + 1);
			this.MoveTween = ULTweenBPLibrary.LocalPositionXTo(item, 0f, 0.3f, 0f, LTweenEase.InOutCubic);
			this.MoveTween.OnCompleteCallBack.Bind(delegate()
			{
				this.MoveTween = null;
			});
		}
	}

	// Token: 0x0600EC2F RID: 60463 RVA: 0x0038140B File Offset: 0x0037F60B
	protected override void OnBeforeDestroy()
	{
		if (this.PageDotLayout != null)
		{
			this.PageDotLayout.ClearChildren();
			this.PageDotLayout = null;
		}
		if (this.MoveTween != null)
		{
			this.MoveTween.Kill(false);
			this.MoveTween = null;
		}
	}

	// Token: 0x0600EC30 RID: 60464 RVA: 0x00381444 File Offset: 0x0037F644
	private ILayoutItem<TutorialPageItem> InitDetail(object data, UUIItem uiItem, int index)
	{
		TutorialPageItem tutorialPageItem = new TutorialPageItem(uiItem);
		tutorialPageItem.Init();
		tutorialPageItem.UpdateShow(false);
		return new LayoutItem<TutorialPageItem>
		{
			Key = index,
			Value = tutorialPageItem
		};
	}

	// Token: 0x0600EC31 RID: 60465 RVA: 0x0038147F File Offset: 0x0037F67F
	private void SwitchPanelAnim()
	{
		this.LastShowPanel.SetUiActive(true);
		this.CurrentShowPanel.PlayAnime(true);
		this.LastShowPanel.PlayAnime(false);
	}

	// Token: 0x0600EC32 RID: 60466 RVA: 0x003814A8 File Offset: 0x0037F6A8
	protected override UniTask OnBeforeStartAsync()
	{
		HelpGuideView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HelpGuideView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600EC33 RID: 60467 RVA: 0x003814EC File Offset: 0x0037F6EC
	protected override void OnStart()
	{
		this.RefreshView(0);
		base.GetItem(14).SetUIActive(false);
		base.GetButton(13).RootUIComp.Get().SetUIActive(false);
	}

	// Token: 0x0600EC34 RID: 60468 RVA: 0x0038152C File Offset: 0x0037F72C
	protected override void OnBeforeShow()
	{
		this.UiViewSequence.PlaySequence("StartAtOnce", false, null);
		base.GetItem(10).SetUIActive(true);
		base.GetItem(11).SetUIActive(true);
		base.GetItem(9).SetUIActive(false);
	}

	// Token: 0x0600EC35 RID: 60469 RVA: 0x00381580 File Offset: 0x0037F780
	private void RefreshView(int index)
	{
		if (this.PageArray.Count > 1)
		{
			this.PageDotLayout.GetLayoutItemByIndex(this.NowPage).UpdateShow(false);
			this.PageDotLayout.GetLayoutItemByIndex(index).UpdateShow(true);
			base.GetButton(7).SetSelfInteractive(index > 0);
			base.GetButton(8).SetSelfInteractive(index < this.PageArray.Count - 1);
			if (this.LastShowPanel != null)
			{
				HelpText value = this.PageArray[this.NowPage];
				this.LastShowPanel.RefreshPage(new HelpText?(value));
			}
		}
		this.NowPage = index;
		HelpText value2 = this.PageArray[this.NowPage];
		this.CurrentShowPanel.RefreshPage(new HelpText?(value2));
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), value2.Title, Array.Empty<object>());
	}

	// Token: 0x04006D7F RID: 28031
	private const float TWEEN_TIME = 0.3f;

	// Token: 0x04006D80 RID: 28032
	protected int HelpGroupId;

	// Token: 0x04006D81 RID: 28033
	private IReadOnlyList<HelpText> PageArray = new List<HelpText>();

	// Token: 0x04006D82 RID: 28034
	private int NowPage;

	// Token: 0x04006D83 RID: 28035
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<TutorialPageItem> PageDotLayout;

	// Token: 0x04006D84 RID: 28036
	[Nullable(2)]
	private HelpGuidePage CurrentShowPanel;

	// Token: 0x04006D85 RID: 28037
	[Nullable(2)]
	private HelpGuidePage LastShowPanel;

	// Token: 0x04006D86 RID: 28038
	[Nullable(2)]
	private ULTweener MoveTween;

	// Token: 0x0200840D RID: 33805
	[NullableContext(0)]
	public enum ETutorialsPopupComponents
	{
		// Token: 0x0402AFAD RID: 176045
		SprIcon,
		// Token: 0x0402AFAE RID: 176046
		TxtTitle,
		// Token: 0x0402AFAF RID: 176047
		BtnBack,
		// Token: 0x0402AFB0 RID: 176048
		PnlMid,
		// Token: 0x0402AFB1 RID: 176049
		PnlBottom,
		// Token: 0x0402AFB2 RID: 176050
		PnlPages,
		// Token: 0x0402AFB3 RID: 176051
		UiItemPagesDot,
		// Token: 0x0402AFB4 RID: 176052
		BtnArrowL,
		// Token: 0x0402AFB5 RID: 176053
		BtnArrowR,
		// Token: 0x0402AFB6 RID: 176054
		UiItemTutorialsTps,
		// Token: 0x0402AFB7 RID: 176055
		UiItemLayerBg,
		// Token: 0x0402AFB8 RID: 176056
		UiItemLayerUi,
		// Token: 0x0402AFB9 RID: 176057
		PageParent,
		// Token: 0x0402AFBA RID: 176058
		BtnBg,
		// Token: 0x0402AFBB RID: 176059
		TipReadAll
	}
}
