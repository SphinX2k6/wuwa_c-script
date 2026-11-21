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

// Token: 0x0200128F RID: 4751
[NullableContext(2)]
[Nullable(0)]
public class GuideTutorialView : UiViewBase
{
	// Token: 0x0600BC4A RID: 48202 RVA: 0x00379C8E File Offset: 0x00377E8E
	[NullableContext(1)]
	public GuideTutorialView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600BC4B RID: 48203 RVA: 0x00379CA0 File Offset: 0x00377EA0
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

	// Token: 0x0600BC4C RID: 48204 RVA: 0x00379F64 File Offset: 0x00378164
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

	// Token: 0x0600BC4D RID: 48205 RVA: 0x0037A040 File Offset: 0x00378240
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

	// Token: 0x0600BC4E RID: 48206 RVA: 0x0037A124 File Offset: 0x00378324
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

	// Token: 0x0600BC4F RID: 48207 RVA: 0x0037A154 File Offset: 0x00378354
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

	// Token: 0x0600BC50 RID: 48208 RVA: 0x0037A20C File Offset: 0x0037840C
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

	// Token: 0x0600BC51 RID: 48209 RVA: 0x0037A250 File Offset: 0x00378450
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

	// Token: 0x0600BC52 RID: 48210 RVA: 0x0037A2A4 File Offset: 0x003784A4
	private void PlayTip()
	{
		this.LevelSequencePlayer.PlayLevelSequenceByName("Start", true, null, false);
		base.GetItem(10).SetUIActive(false);
		base.GetItem(11).SetUIActive(false);
		base.GetItem(9).SetUIActive(true);
	}

	// Token: 0x0600BC53 RID: 48211 RVA: 0x0037A2F8 File Offset: 0x003784F8
	private void PlayAtOnce()
	{
		this.UiViewSequence.PlaySequence("StartAtOnce", true, null);
		base.GetItem(10).SetUIActive(true);
		base.GetItem(11).SetUIActive(true);
		base.GetItem(9).SetUIActive(false);
	}

	// Token: 0x0600BC54 RID: 48212 RVA: 0x0037A34C File Offset: 0x0037854C
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

	// Token: 0x0600BC55 RID: 48213 RVA: 0x0037A3AC File Offset: 0x003785AC
	protected override UniTask OnBeforeStartAsync()
	{
		GuideTutorialView.<OnBeforeStartAsync>d__24 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GuideTutorialView.<OnBeforeStartAsync>d__24>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600BC56 RID: 48214 RVA: 0x0037A3F0 File Offset: 0x003785F0
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

	// Token: 0x0600BC57 RID: 48215 RVA: 0x0037A579 File Offset: 0x00378779
	protected override void OnBeforeShow()
	{
		if (this.TutorialInfo.TutorialTip)
		{
			this.PlayAtOnce();
			return;
		}
		this.PlayTip();
	}

	// Token: 0x0600BC58 RID: 48216 RVA: 0x0037A598 File Offset: 0x00378798
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

	// Token: 0x0600BC59 RID: 48217 RVA: 0x0037A6EC File Offset: 0x003788EC
	private void TryRemoveTutorialRedDot()
	{
		TutorialSaveData savedDataById = TutorialModel.Instance.GetSavedDataById(this.TutorialInfo.GuideId);
		if (savedDataById != null && savedDataById.HasRedDot)
		{
			TutorialController.Instance.RemoveRedDotTutorialId(savedDataById.TutorialId);
		}
	}

	// Token: 0x0600BC5A RID: 48218 RVA: 0x0037A72A File Offset: 0x0037892A
	private void OnCloseClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x04006C44 RID: 27716
	private const float TWEEN_TIME = 0.3f;

	// Token: 0x04006C45 RID: 27717
	public TutorialListInfo TutorialInfo;

	// Token: 0x04006C46 RID: 27718
	public bool IsPopView = true;

	// Token: 0x04006C47 RID: 27719
	private int[] PageArray;

	// Token: 0x04006C48 RID: 27720
	private int NowPage;

	// Token: 0x04006C49 RID: 27721
	private bool HasReadToEnd;

	// Token: 0x04006C4A RID: 27722
	private bool RequireReadAll;

	// Token: 0x04006C4B RID: 27723
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<TutorialPageItem> PageDotLayout;

	// Token: 0x04006C4C RID: 27724
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04006C4D RID: 27725
	private GuideTutorialPagePanel CurrentShowPanel;

	// Token: 0x04006C4E RID: 27726
	private GuideTutorialPagePanel LastShowPanel;

	// Token: 0x04006C4F RID: 27727
	private ULTweener MoveTween;

	// Token: 0x02007536 RID: 30006
	[NullableContext(0)]
	public enum ETutorialsPopupComponents
	{
		// Token: 0x04026154 RID: 155988
		SprIcon,
		// Token: 0x04026155 RID: 155989
		TxtTitle,
		// Token: 0x04026156 RID: 155990
		BtnBack,
		// Token: 0x04026157 RID: 155991
		PnlMid,
		// Token: 0x04026158 RID: 155992
		PnlBottom,
		// Token: 0x04026159 RID: 155993
		PnlPages,
		// Token: 0x0402615A RID: 155994
		UiItemPagesDot,
		// Token: 0x0402615B RID: 155995
		BtnArrowL,
		// Token: 0x0402615C RID: 155996
		BtnArrowR,
		// Token: 0x0402615D RID: 155997
		UiItemTutorialsTps,
		// Token: 0x0402615E RID: 155998
		UiItemLayerBg,
		// Token: 0x0402615F RID: 155999
		UiItemLayerUi,
		// Token: 0x04026160 RID: 156000
		PageParent,
		// Token: 0x04026161 RID: 156001
		BtnBg,
		// Token: 0x04026162 RID: 156002
		TipReadAll
	}
}
