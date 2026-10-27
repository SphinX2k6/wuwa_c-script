using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Guide.GroupInfo;
using CSharpScript.Game.Guide.StepInfo;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001DCD RID: 7629
[NullableContext(2)]
[Nullable(0)]
public class GuideTutorialView : UiViewBase
{
	// Token: 0x0600E82B RID: 59435 RVA: 0x0036DF8E File Offset: 0x0036C18E
	[NullableContext(1)]
	public GuideTutorialView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E82C RID: 59436 RVA: 0x0036DFA0 File Offset: 0x0036C1A0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 15;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 4;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnCloseClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(13, new Action(this.OnCloseClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.PrePage));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.NextPage));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600E82D RID: 59437 RVA: 0x0036E264 File Offset: 0x0036C464
	private void PrePage()
	{
		if (this.MoveTween == null && this.NowPage > 0)
		{
			UUIItem rootItem = this.CurrentShowPanel.GetRootItem();
			FVector relativeLocation = rootItem.RelativeLocation;
			UUIItem item = base.GetItem(12);
			item.SetUIRelativeLocation(new FVector(-item.Width, item.RelativeLocation.Y, item.RelativeLocation.Z));
			this.InitLastPanel();
			this.LastShowPanel.GetRootItem().SetUIRelativeLocation(new FVector(rootItem.Width, relativeLocation.Y, relativeLocation.Z));
			this.RefreshView(this.NowPage - 1);
			this.MoveTween = ULTweenBPLibrary.LocalPositionXTo(item, 0f, 0.3f, 0f, LTweenEase.InOutCubic);
			this.MoveTween.OnCompleteCallBack.Bind(delegate()
			{
				this.MoveTween = null;
			});
		}
	}

	// Token: 0x0600E82E RID: 59438 RVA: 0x0036E340 File Offset: 0x0036C540
	private void NextPage()
	{
		if (this.MoveTween == null && this.NowPage < this.PageArray.Length - 1)
		{
			UUIItem rootItem = this.CurrentShowPanel.GetRootItem();
			FVector relativeLocation = rootItem.RelativeLocation;
			UUIItem item = base.GetItem(12);
			item.SetUIRelativeLocation(new FVector(item.Width, item.RelativeLocation.Y, item.RelativeLocation.Z));
			this.InitLastPanel();
			this.LastShowPanel.GetRootItem().SetUIRelativeLocation(new FVector(-rootItem.Width, relativeLocation.Y, relativeLocation.Z));
			this.RefreshView(this.NowPage + 1);
			this.MoveTween = ULTweenBPLibrary.LocalPositionXTo(item, 0f, 0.3f, 0f, LTweenEase.InOutCubic);
			this.MoveTween.OnCompleteCallBack.Bind(delegate()
			{
				this.MoveTween = null;
			});
		}
	}

	// Token: 0x0600E82F RID: 59439 RVA: 0x0036E424 File Offset: 0x0036C624
	protected override void OnBeforeHide()
	{
		TutorialListInfo tutorialInfo = this.TutorialInfo;
		if (tutorialInfo == null)
		{
			return;
		}
		GuideStepInfo ownerStep = tutorialInfo.OwnerStep;
		if (ownerStep == null)
		{
			return;
		}
		GuideGroupInfo ownerGroup = ownerStep.OwnerGroup;
		if (ownerGroup == null)
		{
			return;
		}
		CustomPromise finishPromise = ownerGroup.FinishPromise;
		if (finishPromise == null)
		{
			return;
		}
		finishPromise.SetResult();
	}

	// Token: 0x0600E830 RID: 59440 RVA: 0x0036E454 File Offset: 0x0036C654
	protected override void OnBeforeDestroy()
	{
		GenericLayoutNew<TutorialPageItem> pageDotLayout = this.PageDotLayout;
		if (pageDotLayout != null)
		{
			pageDotLayout.ClearChildren();
		}
		this.PageDotLayout = null;
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		this.LevelSequencePlayer = null;
		if (this.TutorialInfo != null)
		{
			GuideModel.Instance.ClipTipState();
			GuideModel.Instance.RemoveCurrentTutorialInfo();
			GuideModel.Instance.TryShowTutorial();
		}
		TutorialController.Instance.TryOpenAwardUiViewPending();
		GuideTutorialPagePanel currentShowPanel = this.CurrentShowPanel;
		if (currentShowPanel != null)
		{
			currentShowPanel.Destroy(null);
		}
		this.CurrentShowPanel = null;
		GuideTutorialPagePanel lastShowPanel = this.LastShowPanel;
		if (lastShowPanel != null)
		{
			lastShowPanel.Destroy(null);
		}
		this.LastShowPanel = null;
		ULTweener moveTween = this.MoveTween;
		if (moveTween != null)
		{
			moveTween.Kill(false);
		}
		this.MoveTween = null;
	}

	// Token: 0x0600E831 RID: 59441 RVA: 0x0036E50C File Offset: 0x0036C70C
	[NullableContext(1)]
	private ILayoutItem<TutorialPageItem> InitDetail(object tempData, UUIItem uiItem, int index)
	{
		int num = (int)tempData;
		TutorialPageItem tutorialPageItem = new TutorialPageItem(uiItem);
		tutorialPageItem.Init();
		tutorialPageItem.UpdateShow(false);
		return new LayoutItem<TutorialPageItem>
		{
			Key = index,
			Value = tutorialPageItem
		};
	}

	// Token: 0x0600E832 RID: 59442 RVA: 0x0036E550 File Offset: 0x0036C750
	[NullableContext(1)]
	private void FinishSequenceEvent(string sequenceName)
	{
		if (sequenceName == "Start".ToString())
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
			return;
		}
		if (sequenceName == "Close".ToString())
		{
			this.PlayAtOnce();
		}
	}

	// Token: 0x0600E833 RID: 59443 RVA: 0x0036E5A4 File Offset: 0x0036C7A4
	private void PlayTip()
	{
		this.LevelSequencePlayer.PlayLevelSequenceByName("Start", true, null, false);
		base.GetItem(10).SetUIActive(false);
		base.GetItem(11).SetUIActive(false);
		base.GetItem(9).SetUIActive(true);
	}

	// Token: 0x0600E834 RID: 59444 RVA: 0x0036E5F8 File Offset: 0x0036C7F8
	private void PlayAtOnce()
	{
		this.UiViewSequence.PlaySequence("StartAtOnce", true, null);
		base.GetItem(10).SetUIActive(true);
		base.GetItem(11).SetUIActive(true);
		base.GetItem(9).SetUIActive(false);
	}

	// Token: 0x0600E835 RID: 59445 RVA: 0x0036E64C File Offset: 0x0036C84C
	private void InitLastPanel()
	{
		if (this.LastShowPanel == null)
		{
			UUIItem uiItem = LguiUtil.Instance.CopyItem(base.GetItem(3), base.GetItem(12));
			this.LastShowPanel = new GuideTutorialPagePanel();
			this.LastShowPanel.Init(uiItem);
		}
		this.CurrentShowPanel.PlayAnime(true);
		this.LastShowPanel.PlayAnime(false);
	}

	// Token: 0x0600E836 RID: 59446 RVA: 0x0036E6AC File Offset: 0x0036C8AC
	protected override UniTask OnBeforeStartAsync()
	{
		GuideTutorialView.<OnBeforeStartAsync>d__24 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GuideTutorialView.<OnBeforeStartAsync>d__24>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E837 RID: 59447 RVA: 0x0036E6F0 File Offset: 0x0036C8F0
	protected override void OnStart()
	{
		this.TutorialInfo = (this.OpenParam as TutorialListInfo);
		this.PageDotLayout = new GenericLayoutNew<TutorialPageItem>(base.GetHorizontalLayout(5), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<TutorialPageItem>(this.InitDetail), base.GetItem(6));
		this.LevelSequencePlayer = new LevelSequencePlayer(base.GetItem(9));
		this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.FinishSequenceEvent), false);
		this.PageArray = GuideConfig.Instance.GetGuideTutorialPageIds(this.TutorialInfo.GuideId);
		this.TryRemoveTutorialRedDot();
		if (this.PageArray.Length <= 1)
		{
			base.GetButton(7).RootUIComp.Get().SetUIActive(false);
			base.GetButton(8).RootUIComp.Get().SetUIActive(false);
			base.GetItem(4).SetUIActive(false);
		}
		else
		{
			base.GetButton(7).RootUIComp.Get().SetUIActive(true);
			base.GetButton(8).RootUIComp.Get().SetUIActive(true);
			base.GetItem(4).SetUIActive(true);
			this.PageDotLayout.RebuildLayoutByDataNew<int>(this.PageArray, null);
		}
		this.RequireReadAll = true;
		base.GetButton(2).RootUIComp.Get().SetUIActive(false);
		base.GetButton(13).RootUIComp.Get().SetUIActive(false);
		base.GetItem(14).SetUIActive(true);
		this.RefreshView(0);
	}

	// Token: 0x0600E838 RID: 59448 RVA: 0x0036E879 File Offset: 0x0036CA79
	protected override void OnBeforeShow()
	{
		if (this.TutorialInfo.TutorialTip)
		{
			this.PlayAtOnce();
			return;
		}
		this.PlayTip();
	}

	// Token: 0x0600E839 RID: 59449 RVA: 0x0036E898 File Offset: 0x0036CA98
	private void RefreshView(int index)
	{
		if (this.PageArray.Length > 1)
		{
			this.PageDotLayout.GetLayoutItemByIndex(this.NowPage).UpdateShow(false);
			this.PageDotLayout.GetLayoutItemByIndex(index).UpdateShow(true);
			base.GetButton(7).SetSelfInteractive(index > 0);
			base.GetButton(8).SetSelfInteractive(index < this.PageArray.Length - 1);
			if (this.LastShowPanel != null)
			{
				GuideTutorialPage? guideTutorialPage = GuideConfig.Instance.GetGuideTutorialPage(this.PageArray[this.NowPage]);
				this.LastShowPanel.RefreshPage(guideTutorialPage);
			}
		}
		this.NowPage = index;
		if (this.NowPage == this.PageArray.Length - 1)
		{
			base.GetButton(2).RootUIComp.Get().SetUIActive(true);
			base.GetButton(13).RootUIComp.Get().SetUIActive(true);
			this.HasReadToEnd = true;
		}
		base.GetItem(14).SetUIActive(!this.HasReadToEnd && this.RequireReadAll);
		GuideTutorialPage? guideTutorialPage2 = GuideConfig.Instance.GetGuideTutorialPage(this.PageArray[this.NowPage]);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), guideTutorialPage2.Value.Title, Array.Empty<object>());
		this.CurrentShowPanel.RefreshPage(guideTutorialPage2);
	}

	// Token: 0x0600E83A RID: 59450 RVA: 0x0036E9EC File Offset: 0x0036CBEC
	private void TryRemoveTutorialRedDot()
	{
		TutorialSaveData savedDataById = TutorialModel.Instance.GetSavedDataById(this.TutorialInfo.GuideId);
		if (savedDataById != null && savedDataById.HasRedDot)
		{
			TutorialController.Instance.RemoveRedDotTutorialId(savedDataById.TutorialId);
		}
	}

	// Token: 0x0600E83B RID: 59451 RVA: 0x0036EA2A File Offset: 0x0036CC2A
	private void OnCloseClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x04006B63 RID: 27491
	private const float TWEEN_TIME = 0.3f;

	// Token: 0x04006B64 RID: 27492
	public TutorialListInfo TutorialInfo;

	// Token: 0x04006B65 RID: 27493
	public bool IsPopView = true;

	// Token: 0x04006B66 RID: 27494
	private int[] PageArray;

	// Token: 0x04006B67 RID: 27495
	private int NowPage;

	// Token: 0x04006B68 RID: 27496
	private bool HasReadToEnd;

	// Token: 0x04006B69 RID: 27497
	private bool RequireReadAll;

	// Token: 0x04006B6A RID: 27498
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<TutorialPageItem> PageDotLayout;

	// Token: 0x04006B6B RID: 27499
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04006B6C RID: 27500
	private GuideTutorialPagePanel CurrentShowPanel;

	// Token: 0x04006B6D RID: 27501
	private GuideTutorialPagePanel LastShowPanel;

	// Token: 0x04006B6E RID: 27502
	private ULTweener MoveTween;

	// Token: 0x020083AF RID: 33711
	[NullableContext(0)]
	public enum ETutorialsPopupComponents
	{
		// Token: 0x0402AE2F RID: 175663
		SprIcon,
		// Token: 0x0402AE30 RID: 175664
		TxtTitle,
		// Token: 0x0402AE31 RID: 175665
		BtnBack,
		// Token: 0x0402AE32 RID: 175666
		PnlMid,
		// Token: 0x0402AE33 RID: 175667
		PnlBottom,
		// Token: 0x0402AE34 RID: 175668
		PnlPages,
		// Token: 0x0402AE35 RID: 175669
		UiItemPagesDot,
		// Token: 0x0402AE36 RID: 175670
		BtnArrowL,
		// Token: 0x0402AE37 RID: 175671
		BtnArrowR,
		// Token: 0x0402AE38 RID: 175672
		UiItemTutorialsTps,
		// Token: 0x0402AE39 RID: 175673
		UiItemLayerBg,
		// Token: 0x0402AE3A RID: 175674
		UiItemLayerUi,
		// Token: 0x0402AE3B RID: 175675
		PageParent,
		// Token: 0x0402AE3C RID: 175676
		BtnBg,
		// Token: 0x0402AE3D RID: 175677
		TipReadAll
	}
}
