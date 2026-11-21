using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000855 RID: 2133
[NullableContext(1)]
[Nullable(0)]
public class ActivitySubViewNewcomerJourney : ActivitySubViewBase
{
	// Token: 0x060060B9 RID: 24761 RVA: 0x001EDA94 File Offset: 0x001EBC94
	protected unsafe override void OnRegisterComponent()
	{
		int num = 25;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(21, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 3;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.ClickGetCharacterBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(10, new Action(this.ClickGetBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(14, new Action(this.ClickPreviewBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060060BA RID: 24762 RVA: 0x001EDE8A File Offset: 0x001EC08A
	private void ClickGetCharacterBtn()
	{
		if (this.ActivityDataBase == null)
		{
			return;
		}
		if (!this.ActivityDataBase.GetCanGetCharacter())
		{
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.NewcomerJourneyChoseRoleView, null, delegate(bool success, int viewId)
		{
			base.AddChild(UiManager.Instance.GetView(viewId));
		});
	}

	// Token: 0x060060BB RID: 24763 RVA: 0x001EDEC0 File Offset: 0x001EC0C0
	private void ClickGetBtn()
	{
		if (this.ActivityDataBase == null || this.SelectChapterConfig == null)
		{
			return;
		}
		if (!this.ActivityDataBase.GetChapterCanGetReward(this.SelectChapterConfig.Value.Id))
		{
			return;
		}
		ActivityNewcomerJourneyController.Instance.GetChapterReward(this.ActivityDataBase.Id, this.SelectChapterConfig.Value.Id);
		this.IsSendGetReward = true;
	}

	// Token: 0x060060BC RID: 24764 RVA: 0x001EDF34 File Offset: 0x001EC134
	private void ClickPreviewBtn()
	{
		if (this.ActivityDataBase == null)
		{
			return;
		}
		List<int> previewCharacterList = this.ActivityDataBase.GetPreviewCharacterList();
		RoleController.Instance.OpenRoleMainView(ERoleAgentType.Preview, 0, previewCharacterList, null, null);
	}

	// Token: 0x060060BD RID: 24765 RVA: 0x001EDF6D File Offset: 0x001EC16D
	protected override void OnSetData()
	{
		this.ActivityDataBase = (this.ActivityBaseData as ActivityNewcomerJourneyData);
	}

	// Token: 0x060060BE RID: 24766 RVA: 0x001EDF80 File Offset: 0x001EC180
	private NewcomerJourneyTabItem CreateTabItem()
	{
		NewcomerJourneyTabItem newcomerJourneyTabItem = new NewcomerJourneyTabItem();
		newcomerJourneyTabItem.SetActivityData(this.ActivityDataBase);
		newcomerJourneyTabItem.SetBtnClickCallback(new Action<AdventureTaskChapterV2, int>(this.OnClickTab));
		return newcomerJourneyTabItem;
	}

	// Token: 0x060060BF RID: 24767 RVA: 0x001EDFA5 File Offset: 0x001EC1A5
	private void OnClickTab(AdventureTaskChapterV2 chapterConfig, int gridIndex)
	{
		this.SelectChapterConfig = new AdventureTaskChapterV2?(chapterConfig);
		GenericScrollViewNew<NewcomerJourneyTabItem, AdventureTaskChapterV2> tabLayout = this.TabLayout;
		if (tabLayout != null)
		{
			GenericLayout<NewcomerJourneyTabItem, AdventureTaskChapterV2> genericLayout = tabLayout.GetGenericLayout();
			if (genericLayout != null)
			{
				genericLayout.SelectGridProxy(gridIndex, false);
			}
		}
		this.RefreshSelectChapterView(true);
	}

	// Token: 0x060060C0 RID: 24768 RVA: 0x001EDFD8 File Offset: 0x001EC1D8
	private NewcomerJourneyTaskItem CreateTaskItem()
	{
		NewcomerJourneyTaskItem newcomerJourneyTaskItem = new NewcomerJourneyTaskItem();
		newcomerJourneyTaskItem.SetActivityData(this.ActivityDataBase);
		return newcomerJourneyTaskItem;
	}

	// Token: 0x060060C1 RID: 24769 RVA: 0x001EDFEB File Offset: 0x001EC1EB
	private CommonItemSmallItemGrid CreateRewardItem()
	{
		return new CommonItemSmallItemGrid
		{
			ShowReceivedCallBack = delegate(TItem data)
			{
				if (this.ActivityDataBase == null || this.SelectChapterConfig == null)
				{
					return false;
				}
				int id = this.SelectChapterConfig.Value.Id;
				return this.ActivityDataBase.GetChapterRewardHasGet(id);
			}
		};
	}

	// Token: 0x060060C2 RID: 24770 RVA: 0x001EE004 File Offset: 0x001EC204
	private void RefreshGetCharacterView()
	{
		bool characterHasGet = this.ActivityDataBase.GetCharacterHasGet();
		bool canGetCharacter = this.ActivityDataBase.GetCanGetCharacter();
		base.GetItem(24).SetUIActive(canGetCharacter);
		base.GetItem(13).SetUIActive(canGetCharacter);
		UUIButtonComponent button = base.GetButton(0);
		if (button != null)
		{
			button.SetSelfInteractive(canGetCharacter);
		}
		base.GetItem(23).SetUIActive(!characterHasGet && !canGetCharacter);
		base.GetItem(20).SetUIActive(characterHasGet);
		this.SetRewardBgTexture();
	}

	// Token: 0x060060C3 RID: 24771 RVA: 0x001EE084 File Offset: 0x001EC284
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewNewcomerJourney.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewNewcomerJourney.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060060C4 RID: 24772 RVA: 0x001EE0C8 File Offset: 0x001EC2C8
	protected override void OnBeforeShow()
	{
		Activity? activityConfig = ActivityConfig.Instance.GetActivityConfig(this.ActivityDataBase.Id);
		if (activityConfig != null)
		{
			base.GetText(17).ShowTextNew(activityConfig.Value.Name);
		}
		this.SetLogoTexture();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(11), "NewPlayer_Adventure_001", Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(12), "NewPlayer_Adventure_002", Array.Empty<object>());
		this.RefreshGetCharacterView();
	}

	// Token: 0x060060C5 RID: 24773 RVA: 0x001EE154 File Offset: 0x001EC354
	private void SetLogoTexture()
	{
		UUITexture texture = base.GetTexture(19);
		if (texture != null)
		{
			PlayerInfoModel instance = PlayerInfoModel.Instance;
			string resourceId = (((instance != null) ? instance.GetPlayerGender() : EPlayerGender.None) == EPlayerGender.Male) ? "T_NewcomerLogoMale" : "T_NewcomerLogoFemale";
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			if (!string.IsNullOrEmpty(resourcePath))
			{
				base.SetTextureByPath(resourcePath, texture, null, null);
			}
		}
	}

	// Token: 0x060060C6 RID: 24774 RVA: 0x001EE1B4 File Offset: 0x001EC3B4
	private void SetRewardBgTexture()
	{
		UUITexture texture = base.GetTexture(21);
		if (texture != null)
		{
			string resourceId = this.ActivityDataBase.GetCanGetCharacter() ? "T_RewardTipBgReward" : "T_RewardTipBgNor";
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			if (!string.IsNullOrEmpty(resourcePath))
			{
				base.SetTextureByPath(resourcePath, texture, null, null);
			}
		}
	}

	// Token: 0x060060C7 RID: 24775 RVA: 0x001EE210 File Offset: 0x001EC410
	private int GetInitSelectIndex()
	{
		List<AdventureTaskChapterV2> chapterList = this.ActivityDataBase.GetChapterList();
		int num = -1;
		int num2 = 0;
		while (num2 < chapterList.Count && !this.ActivityDataBase.GetChapterIsLock(chapterList[num2].Id))
		{
			if (this.ActivityDataBase.GetChapterHasReward(chapterList[num2].Id))
			{
				num = num2;
				break;
			}
			num2++;
		}
		if (num == -1)
		{
			num = 0;
			AdventureTaskChapterV2 adventureTaskChapterV = chapterList[chapterList.Count - 1];
			bool chapterTaskAllComplete = this.ActivityDataBase.GetChapterTaskAllComplete(adventureTaskChapterV.Id);
			for (int i = 0; i < chapterList.Count; i++)
			{
				if (chapterTaskAllComplete && !this.ActivityDataBase.GetChapterTaskAllComplete(chapterList[i].Id))
				{
					num = i;
					break;
				}
				if (!chapterTaskAllComplete && !this.ActivityDataBase.GetChapterIsLock(chapterList[i].Id))
				{
					num = i;
				}
			}
		}
		return num;
	}

	// Token: 0x060060C8 RID: 24776 RVA: 0x001EE308 File Offset: 0x001EC508
	private void RefreshSelectChapterView(bool isPlayTurnAnimation)
	{
		if (this.SelectChapterConfig == null)
		{
			return;
		}
		int id = this.SelectChapterConfig.Value.Id;
		List<TItem> chapterRewardList = this.ActivityDataBase.GetChapterRewardList(id);
		this.RewardLayout.RefreshByData(chapterRewardList, null, false);
		bool chapterIsLock = this.ActivityDataBase.GetChapterIsLock(id);
		base.GetScrollViewWithScrollbar(3).RootUIComp.Get().SetUIActive(!chapterIsLock);
		base.GetItem(15).SetUIActive(chapterIsLock);
		base.GetText(6).SetUIActive(!chapterIsLock);
		if (chapterIsLock)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(16), this.SelectChapterConfig.Value.LockedDesc, Array.Empty<object>());
			base.GetItem(9).SetUIActive(true);
			base.GetItem(22).SetUIActive(false);
			base.SetButtonUiActive(10, false);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "NewPlayer_Adventure_004", Array.Empty<object>());
			return;
		}
		List<NewcomerJourneyTaskData> chapterTaskList = this.ActivityDataBase.GetChapterTaskList(id);
		this.TaskLayout.RefreshByData(chapterTaskList, isPlayTurnAnimation ? delegate()
		{
			GenericScrollViewNew<NewcomerJourneyTaskItem, NewcomerJourneyTaskData> taskLayout = this.TaskLayout;
			if (taskLayout == null)
			{
				return;
			}
			taskLayout.PlayTurnAnimation();
		} : null, false);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), this.SelectChapterConfig.Value.ChapterTitle, Array.Empty<object>());
		int chapterCompleteNum = this.ActivityDataBase.GetChapterCompleteNum(id);
		int rewardUnlockCount = this.SelectChapterConfig.Value.RewardUnlockCount;
		UUIText text = base.GetText(6);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(chapterCompleteNum);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(rewardUnlockCount);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		base.GetItem(9).SetUIActive(chapterCompleteNum < rewardUnlockCount);
		bool chapterCanGetReward = this.ActivityDataBase.GetChapterCanGetReward(id);
		base.SetButtonUiActive(10, chapterCanGetReward);
		bool chapterRewardHasGet = this.ActivityDataBase.GetChapterRewardHasGet(id);
		base.GetItem(22).SetUIActive(chapterRewardHasGet);
	}

	// Token: 0x060060C9 RID: 24777 RVA: 0x001EE508 File Offset: 0x001EC708
	protected override void OnSequenceStart(string sequenceName)
	{
		if (sequenceName == "Start")
		{
			GenericScrollViewNew<NewcomerJourneyTaskItem, NewcomerJourneyTaskData> taskLayout = this.TaskLayout;
			if (taskLayout == null)
			{
				return;
			}
			taskLayout.PlayTurnAnimation();
		}
	}

	// Token: 0x060060CA RID: 24778 RVA: 0x001EE528 File Offset: 0x001EC728
	protected override void OnRefreshView()
	{
		List<AdventureTaskChapterV2> chapterList = this.ActivityDataBase.GetChapterList();
		this.TabLayout.RefreshByData(chapterList, delegate
		{
			int num = (this.SelectChapterConfig != null) ? (this.SelectChapterConfig.Value.Sort - 1) : -1;
			if (num < 0)
			{
				num = this.GetInitSelectIndex();
			}
			if (this.IsSendGetReward)
			{
				num = this.ActivityDataBase.GetLastUnLockChapterIndex() - 1;
				num = ((num < 0) ? 0 : num);
				this.IsSendGetReward = false;
			}
			this.SelectChapterConfig = new AdventureTaskChapterV2?(chapterList[num]);
			this.TabLayout.LateScrollToLeft(num);
			this.TabLayout.SelectGridProxy(num, false);
			this.RefreshSelectChapterView(false);
			this.RefreshGetCharacterView();
		}, false);
		EventSystem.Instance.Emit<int>(EEventName.RefreshActivityTab, this.ActivityBaseData.Id);
	}

	// Token: 0x060060CB RID: 24779 RVA: 0x001EE58C File Offset: 0x001EC78C
	protected override void OnTimer(float gap)
	{
		if (this.ActivityBaseData == null)
		{
			return;
		}
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = ActivityModel.Instance.GetTimeVisibleAndRemainTime(this.ActivityBaseData, null);
		bool item = timeVisibleAndRemainTime.Item1;
		string item2 = timeVisibleAndRemainTime.Item2;
		UUIText text = base.GetText(18);
		if (text == null)
		{
			return;
		}
		text.SetUIActive(item);
		text.SetText(item2, true);
	}

	// Token: 0x04003F1E RID: 16158
	private const string NEWCOMER_LOGO_MALE_RESOURCE_ID = "T_NewcomerLogoMale";

	// Token: 0x04003F1F RID: 16159
	private const string NEWCOMER_LOGO_FEMALE_RESOURCE_ID = "T_NewcomerLogoFemale";

	// Token: 0x04003F20 RID: 16160
	private const string NEWCOMER_TIP_NORMAL_RESOURCE_ID = "T_RewardTipBgNor";

	// Token: 0x04003F21 RID: 16161
	private const string NEWCOMER_TIP_REWARD_RESOURCE_ID = "T_RewardTipBgReward";

	// Token: 0x04003F22 RID: 16162
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericScrollViewNew<NewcomerJourneyTabItem, AdventureTaskChapterV2> TabLayout;

	// Token: 0x04003F23 RID: 16163
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericScrollViewNew<NewcomerJourneyTaskItem, NewcomerJourneyTaskData> TaskLayout;

	// Token: 0x04003F24 RID: 16164
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardLayout;

	// Token: 0x04003F25 RID: 16165
	[Nullable(2)]
	private ActivityNewcomerJourneyData ActivityDataBase;

	// Token: 0x04003F26 RID: 16166
	private AdventureTaskChapterV2? SelectChapterConfig;

	// Token: 0x04003F27 RID: 16167
	private bool IsSendGetReward;

	// Token: 0x02006B9A RID: 27546
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040235F5 RID: 144885
		public const int GetCharacterBtn = 0;

		// Token: 0x040235F6 RID: 144886
		public const int TabLayout = 1;

		// Token: 0x040235F7 RID: 144887
		public const int TabItem = 2;

		// Token: 0x040235F8 RID: 144888
		public const int TaskLayout = 3;

		// Token: 0x040235F9 RID: 144889
		public const int TaskItem = 4;

		// Token: 0x040235FA RID: 144890
		public const int TipsTitleText = 5;

		// Token: 0x040235FB RID: 144891
		public const int TipsNumText = 6;

		// Token: 0x040235FC RID: 144892
		public const int RewardLayout = 7;

		// Token: 0x040235FD RID: 144893
		public const int RewardItem = 8;

		// Token: 0x040235FE RID: 144894
		public const int CantGetItem = 9;

		// Token: 0x040235FF RID: 144895
		public const int GetBtn = 10;

		// Token: 0x04023600 RID: 144896
		public const int GetCharacterTitle = 11;

		// Token: 0x04023601 RID: 144897
		public const int GetCharacterDesc = 12;

		// Token: 0x04023602 RID: 144898
		public const int GetCharacterIcon = 13;

		// Token: 0x04023603 RID: 144899
		public const int PreviewBtn = 14;

		// Token: 0x04023604 RID: 144900
		public const int LockItem = 15;

		// Token: 0x04023605 RID: 144901
		public const int LockText = 16;

		// Token: 0x04023606 RID: 144902
		public const int TitleText = 17;

		// Token: 0x04023607 RID: 144903
		public const int TitleSubText = 18;

		// Token: 0x04023608 RID: 144904
		public const int TitleLogo = 19;

		// Token: 0x04023609 RID: 144905
		public const int FinishItem = 20;

		// Token: 0x0402360A RID: 144906
		public const int RewardBg = 21;

		// Token: 0x0402360B RID: 144907
		public const int ChapterTakenItem = 22;

		// Token: 0x0402360C RID: 144908
		public const int CharacterNormalItem = 23;

		// Token: 0x0402360D RID: 144909
		public const int ChapterRedDot = 24;
	}
}
