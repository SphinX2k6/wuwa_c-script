using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001441 RID: 5185
public class ActivityRegressNewVersionMainQuestView : ActivityRegressMainSubViewBase
{
	// Token: 0x0600926C RID: 37484 RVA: 0x001F5ADC File Offset: 0x001F3CDC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUITexture))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickJumpToQuestBtn)),
			new ValueTuple<int, Delegate>(6, new Action(this.OnClickJumpToActivityBtn))
		};
	}

	// Token: 0x0600926D RID: 37485 RVA: 0x001F5C0C File Offset: 0x001F3E0C
	protected override void OnStart()
	{
		base.OnStart();
		RegressBase? latestRegressBase = ActivityRegressModel.Instance.GetLatestRegressBase();
		if (latestRegressBase == null)
		{
			return;
		}
		RegressBase value = latestRegressBase.Value;
		int currentMainLineQuest = ActivityRegressModel.Instance.GetCurrentMainLineQuest();
		this.IsFinishRecommendQuest = (currentMainLineQuest == 0);
		this.RewardScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(3), new Func<CommonItemSmallItemGrid>(this.OnInitItem), null, false, null);
		List<TItem> dropPreviewRewardItemListForPreview = ActivityRegressModel.Instance.GetDropPreviewRewardItemListForPreview(value.RewardPreview);
		this.RewardScrollView.RefreshByData(dropPreviewRewardItemListForPreview, null, false);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), value.Title, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), value.SubTitle, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), value.Description, Array.Empty<object>());
		EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
		base.SetTextureByPath((playerGender == EPlayerGender.Male) ? value.BgPath : value.BgPathF, base.GetTexture(9), null, null);
		if (this.IsFinishRecommendQuest)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "Recall_Main_Task_Finish", Array.Empty<object>());
			base.GetButton(5).RootUIComp.Get().SetUIActive(false);
			base.GetButton(6).RootUIComp.Get().SetUIActive(false);
			base.GetItem(8).SetUIActive(true);
			return;
		}
		this.TargetActivityId = value.TargetActivityId;
		bool flag = this.TargetActivityId != 0 && ActivityModel.Instance.IsActivityOpen(value.TargetActivityId);
		if (ActivityRegressModel.Instance.GetCurrentMainLineBranch() < (ERegressBranchNumber)ActivityRegressModel.Instance.LatestBranch && flag)
		{
			base.GetButton(5).RootUIComp.Get().SetUIActive(false);
			base.GetButton(6).RootUIComp.Get().SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), value.JumpBtnDes, Array.Empty<object>());
		}
		else
		{
			base.GetButton(5).RootUIComp.Get().SetUIActive(true);
			base.GetButton(6).RootUIComp.Get().SetUIActive(false);
		}
		this.TargetQuestId = currentMainLineQuest;
		base.GetItem(8).SetUIActive(false);
		global::Quest quest = QuestNewModel.Instance.GetQuest(currentMainLineQuest);
		if (quest == null)
		{
			return;
		}
		QuestChapter? chapterConfig = QuestNewConfig.Instance.GetChapterConfig(quest.ChapterId.Value);
		if (chapterConfig == null)
		{
			return;
		}
		QuestChapter value2 = chapterConfig.Value;
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(value2.ChapterNum, null);
		string localTextNew2 = ConfigMultiTextLang.GetLocalTextNew(value2.SectionNum, null);
		LguiUtil.Instance.SetLocalText(base.GetText(4), "QuestChapterText", new <>z__ReadOnlyArray<object>(new object[]
		{
			localTextNew,
			localTextNew2
		}));
	}

	// Token: 0x0600926E RID: 37486 RVA: 0x001F5EF9 File Offset: 0x001F40F9
	[NullableContext(1)]
	private CommonItemSmallItemGrid OnInitItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x0600926F RID: 37487 RVA: 0x001F5F00 File Offset: 0x001F4100
	private void OnClickJumpToQuestBtn()
	{
		if (this.TargetQuestId == 0)
		{
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.QuestView, this.TargetQuestId, null);
	}

	// Token: 0x06009270 RID: 37488 RVA: 0x001F5F26 File Offset: 0x001F4126
	private void OnClickJumpToActivityBtn()
	{
		if (this.TargetActivityId == 0)
		{
			return;
		}
		ActivityRegressController.RegressStartJumpToActivity(delegate
		{
			ActivityController.Instance.OpenActivityById(this.TargetActivityId, EActivityViewOpenType.Other, null, null);
		});
	}

	// Token: 0x040040DF RID: 16607
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

	// Token: 0x040040E0 RID: 16608
	private bool IsFinishRecommendQuest;

	// Token: 0x040040E1 RID: 16609
	private int TargetQuestId;

	// Token: 0x040040E2 RID: 16610
	private int TargetActivityId;

	// Token: 0x02007A6F RID: 31343
	private class EComponents
	{
		// Token: 0x0402848E RID: 165006
		public const int QuestTitleText = 0;

		// Token: 0x0402848F RID: 165007
		public const int QuestSubTitleText = 1;

		// Token: 0x04028490 RID: 165008
		public const int QuestDesText = 2;

		// Token: 0x04028491 RID: 165009
		public const int RewardScrollView = 3;

		// Token: 0x04028492 RID: 165010
		public const int CurrentQuestSubTitleText = 4;

		// Token: 0x04028493 RID: 165011
		public const int JumpToQuestViewBtn = 5;

		// Token: 0x04028494 RID: 165012
		public const int JumpToActivityBtn = 6;

		// Token: 0x04028495 RID: 165013
		public const int JumpToQuestViewBtnText = 7;

		// Token: 0x04028496 RID: 165014
		public const int DownItem = 8;

		// Token: 0x04028497 RID: 165015
		public const int BgTexture = 9;
	}
}
