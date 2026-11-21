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

// Token: 0x0200131D RID: 4893
[NullableContext(1)]
[Nullable(0)]
public class HelpGuideView : UiViewBase
{
	// Token: 0x0600C049 RID: 49225 RVA: 0x0038CCFD File Offset: 0x0038AEFD
	public HelpGuideView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C04A RID: 49226 RVA: 0x0038CD14 File Offset: 0x0038AF14
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

	// Token: 0x0600C04B RID: 49227 RVA: 0x0038CEE8 File Offset: 0x0038B0E8
	private void OnCloseClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600C04C RID: 49228 RVA: 0x0038CEF4 File Offset: 0x0038B0F4
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

	// Token: 0x0600C04D RID: 49229 RVA: 0x0038CFD0 File Offset: 0x0038B1D0
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

	// Token: 0x0600C04E RID: 49230 RVA: 0x0038D0B7 File Offset: 0x0038B2B7
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

	// Token: 0x0600C04F RID: 49231 RVA: 0x0038D0F0 File Offset: 0x0038B2F0
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

	// Token: 0x0600C050 RID: 49232 RVA: 0x0038D12B File Offset: 0x0038B32B
	private void SwitchPanelAnim()
	{
		this.LastShowPanel.SetUiActive(true);
		this.CurrentShowPanel.PlayAnime(true);
		this.LastShowPanel.PlayAnime(false);
	}

	// Token: 0x0600C051 RID: 49233 RVA: 0x0038D154 File Offset: 0x0038B354
	protected override UniTask OnBeforeStartAsync()
	{
		HelpGuideView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HelpGuideView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C052 RID: 49234 RVA: 0x0038D198 File Offset: 0x0038B398
	protected override void OnStart()
	{
		this.RefreshView(0);
		base.GetItem(14).SetUIActive(false);
		base.GetButton(13).RootUIComp.Get().SetUIActive(false);
	}

	// Token: 0x0600C053 RID: 49235 RVA: 0x0038D1D8 File Offset: 0x0038B3D8
	protected override void OnBeforeShow()
	{
		this.UiViewSequence.PlaySequence("StartAtOnce", false, null);
		base.GetItem(10).SetUIActive(true);
		base.GetItem(11).SetUIActive(true);
		base.GetItem(9).SetUIActive(false);
	}

	// Token: 0x0600C054 RID: 49236 RVA: 0x0038D22C File Offset: 0x0038B42C
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

	// Token: 0x04006E60 RID: 28256
	private const float TWEEN_TIME = 0.3f;

	// Token: 0x04006E61 RID: 28257
	protected int HelpGroupId;

	// Token: 0x04006E62 RID: 28258
	private IReadOnlyList<HelpText> PageArray = new List<HelpText>();

	// Token: 0x04006E63 RID: 28259
	private int NowPage;

	// Token: 0x04006E64 RID: 28260
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<TutorialPageItem> PageDotLayout;

	// Token: 0x04006E65 RID: 28261
	[Nullable(2)]
	private HelpGuidePage CurrentShowPanel;

	// Token: 0x04006E66 RID: 28262
	[Nullable(2)]
	private HelpGuidePage LastShowPanel;

	// Token: 0x04006E67 RID: 28263
	[Nullable(2)]
	private ULTweener MoveTween;

	// Token: 0x02007592 RID: 30098
	[NullableContext(0)]
	public enum ETutorialsPopupComponents
	{
		// Token: 0x040262D1 RID: 156369
		SprIcon,
		// Token: 0x040262D2 RID: 156370
		TxtTitle,
		// Token: 0x040262D3 RID: 156371
		BtnBack,
		// Token: 0x040262D4 RID: 156372
		PnlMid,
		// Token: 0x040262D5 RID: 156373
		PnlBottom,
		// Token: 0x040262D6 RID: 156374
		PnlPages,
		// Token: 0x040262D7 RID: 156375
		UiItemPagesDot,
		// Token: 0x040262D8 RID: 156376
		BtnArrowL,
		// Token: 0x040262D9 RID: 156377
		BtnArrowR,
		// Token: 0x040262DA RID: 156378
		UiItemTutorialsTps,
		// Token: 0x040262DB RID: 156379
		UiItemLayerBg,
		// Token: 0x040262DC RID: 156380
		UiItemLayerUi,
		// Token: 0x040262DD RID: 156381
		PageParent,
		// Token: 0x040262DE RID: 156382
		BtnBg,
		// Token: 0x040262DF RID: 156383
		TipReadAll
	}
}
