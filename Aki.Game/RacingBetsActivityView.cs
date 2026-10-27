using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Dango.DangoLogic;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.RacingBets;
using CSharpScript.Game.Module.RacingBets.Data;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002724 RID: 10020
[NullableContext(2)]
[Nullable(0)]
public class RacingBetsActivityView : ActivitySubViewBase
{
	// Token: 0x0601488B RID: 84107 RVA: 0x0052F44D File Offset: 0x0052D64D
	protected override void OnSetData()
	{
		this.RacingBetSeasonData = (this.ActivityBaseData as RacingBetsSeasonData);
	}

	// Token: 0x0601488C RID: 84108 RVA: 0x0052F460 File Offset: 0x0052D660
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnRacingBetsPlayerInfoUpdate, new Action(this.RefreshPlayerBetInfo));
		EventSystem.Instance.Add(EEventName.OnRacingBetsRewardRefresh, new Action(this.RefreshRedDot));
	}

	// Token: 0x0601488D RID: 84109 RVA: 0x0052F49A File Offset: 0x0052D69A
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnRacingBetsPlayerInfoUpdate, new Action(this.RefreshPlayerBetInfo));
		EventSystem.Instance.Remove(EEventName.OnRacingBetsRewardRefresh, new Action(this.RefreshRedDot));
	}

	// Token: 0x0601488E RID: 84110 RVA: 0x0052F4D4 File Offset: 0x0052D6D4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 23;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(USpineSkeletonAnimationComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIArtText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(21, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0601488F RID: 84111 RVA: 0x0052F804 File Offset: 0x0052DA04
	protected override UniTask OnBeforeStartAsync()
	{
		RacingBetsActivityView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RacingBetsActivityView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014890 RID: 84112 RVA: 0x0052F848 File Offset: 0x0052DA48
	protected override void OnStart()
	{
		Activity? localConfig = this.RacingBetSeasonData.LocalConfig;
		if (localConfig == null)
		{
			return;
		}
		this.TitleItem.SetActivityBaseData(this.RacingBetSeasonData);
		this.TitleItem.SetTitleByText(this.RacingBetSeasonData.GetTitle());
		string descTheme = localConfig.Value.DescTheme;
		bool flag = !StringUtils.IsEmpty(descTheme);
		this.TitleItem.SetSubTitleVisible(flag);
		if (flag)
		{
			this.TitleItem.SetSubTitleByTextId(descTheme, Array.Empty<string>());
			string descThemeIcon = localConfig.Value.DescThemeIcon;
			if (!string.IsNullOrEmpty(descThemeIcon))
			{
				this.TitleItem.SetSubTitleIconByPath(descThemeIcon, null);
			}
		}
		this.DescriptionItem.SetContentByTextId(localConfig.Value.Desc, Array.Empty<string>());
		List<TItem> previewReward = this.RacingBetSeasonData.GetPreviewReward(null);
		this.RewardListItem.SetTitleByTextId("CollectActivity_reward");
		this.RewardListItem.InitGridLayout(new Func<CommonItemSmallItemGrid>(this.RewardListItem.InitCommonGridItem));
		this.RewardListItem.RefreshItemLayout(previewReward, null);
		this.FunctionalItem.FunctionButton.SetFunction(new Action(this.FunctionExecute));
		this.ActivityInternalRewardItem.BindRedDot(ERedDotName.RedDotRacingBetsActivityInternalReward, 0);
		this.ActivityInternalRewardItem.SetFunction(new Action(this.OnClickActivityInternalRewardItem));
		this.ActivityRewardItem.BindRedDot(ERedDotName.RedDotRacingBetsActivityReward, 0);
		this.ActivityRewardItem.SetFunction(new Action(this.OnClickActivityRewardItem));
	}

	// Token: 0x06014891 RID: 84113 RVA: 0x0052F9D1 File Offset: 0x0052DBD1
	protected override void OnBeforeShow()
	{
		base.GetSpine(6).SetAnimation(0, "start", false).AnimationComplete.Add(delegate(UTrackEntry _)
		{
			base.GetSpine(6).SetAnimation(0, "idle", true);
		});
	}

	// Token: 0x06014892 RID: 84114 RVA: 0x0052F9FC File Offset: 0x0052DBFC
	protected override void OnBeforeHide()
	{
		base.GetSpine(6).ClearTracks();
	}

	// Token: 0x06014893 RID: 84115 RVA: 0x0052FA0C File Offset: 0x0052DC0C
	protected override void OnRefreshView()
	{
		bool flag = this.RacingBetSeasonData.IsUnLock();
		this.FunctionalItem.SetPanelConditionVisible(!flag);
		this.RefreshActivityTimerText();
		if (!flag)
		{
			this.FunctionalItem.SetPerformanceConditionLock(this.RacingBetSeasonData.ConditionGroupId, this.RacingBetSeasonData.Id);
		}
		this.FunctionalItem.FunctionButton.SetUiActive(flag);
		this.FunctionalItem.FunctionButton.SetRedDotVisible(this.RacingBetSeasonData.RedPointShowState);
		this.RefreshPanelInfo();
	}

	// Token: 0x06014894 RID: 84116 RVA: 0x0052FA90 File Offset: 0x0052DC90
	protected override void OnTimer(float gap)
	{
		this.RefreshActivityTimerText();
		this.RefreshPanelInfo();
	}

	// Token: 0x06014895 RID: 84117 RVA: 0x0052FAA0 File Offset: 0x0052DCA0
	private void RefreshActivityTimerText()
	{
		string item = this.GetTimeVisibleAndRemainTime().Item2;
		this.TitleItem.SetTimeTextByText(item);
	}

	// Token: 0x06014896 RID: 84118 RVA: 0x0052FAC5 File Offset: 0x0052DCC5
	private void RefreshRedDot()
	{
		this.FunctionalItem.FunctionButton.SetRedDotVisible(this.RacingBetSeasonData.RedPointShowState);
	}

	// Token: 0x06014897 RID: 84119 RVA: 0x0052FAE2 File Offset: 0x0052DCE2
	private void RefreshPlayerBetInfo()
	{
	}

	// Token: 0x06014898 RID: 84120 RVA: 0x0052FAE4 File Offset: 0x0052DCE4
	private void FunctionExecute()
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			if (this.RacingBetSeasonData.GetIfFirstOpen())
			{
				ActivityController.Instance.RequestReadActivity(this.RacingBetSeasonData);
			}
			if (!this.RacingBetSeasonData.GetPreGuideQuestFinishState())
			{
				UiManager.Instance.OpenView(EUiViewName.QuestView, this.RacingBetSeasonData.GetUnFinishPreGuideQuestId(), null);
			}
			RacingBetsSeasonData racingBetsSeasonData = RacingBetsModel.Instance.GetRacingBetsSeasonData();
			InstanceDungeonController.Instance.PrewarTeamFightRequest(racingBetsSeasonData.GetSeasonConfig().DungeonInstanceId, new List<int>
			{
				RoleModel.Instance.GetCurSelectMainRoleId().Value
			}, racingBetsSeasonData.GetSeasonConfig().DungeonEntranceId, 0, null, null).Forget<bool>();
			RacingBetsModel.Instance.SetIsFromActivityOpenDungeon();
		});
	}

	// Token: 0x06014899 RID: 84121 RVA: 0x0052FB04 File Offset: 0x0052DD04
	private void OnClickActivityRewardItem()
	{
		RacingBetsGroupRewardData groupRewardData = this.RacingBetSeasonData.GetGroupRewardData(ERacingBetsRewardType.BetsCount);
		RacingBetsGroupRewardData groupRewardData2 = this.RacingBetSeasonData.GetGroupRewardData(ERacingBetsRewardType.DailyEarn);
		UiManager.Instance.OpenView(EUiViewName.RacingBetsActivityRewardView, new List<RacingBetsGroupRewardData>
		{
			groupRewardData,
			groupRewardData2
		}, null);
	}

	// Token: 0x0601489A RID: 84122 RVA: 0x0052FB50 File Offset: 0x0052DD50
	private void OnClickActivityInternalRewardItem()
	{
		RacingBetsGroupRewardData groupRewardData = this.RacingBetSeasonData.GetGroupRewardData(ERacingBetsRewardType.DailyGameEarn);
		UiManager.Instance.OpenView(EUiViewName.RacingBetsRewardView, new List<RacingBetsGroupRewardData>
		{
			groupRewardData
		}, null);
	}

	// Token: 0x0601489B RID: 84123 RVA: 0x0052FB88 File Offset: 0x0052DD88
	private void RefreshPanelInfo()
	{
		RacingBetsLegMatchData curLegMatchData = this.RacingBetSeasonData.GetCurLegMatchData();
		if (curLegMatchData == null)
		{
			return;
		}
		if (RacingBetsModel.Instance.IsFinalLegMatch(curLegMatchData.Id) && curLegMatchData.IsLegMatchFinished())
		{
			base.GetItem(19).SetUIActive(true);
			base.GetItem(8).SetUIActive(false);
			this.RefreshWinnerInfo(curLegMatchData);
			return;
		}
		base.GetItem(19).SetUIActive(false);
		base.GetItem(8).SetUIActive(true);
		RacingBetsLegMatchData legMatchDataForMatchStateText = this.RacingBetSeasonData.GetLegMatchDataForMatchStateText();
		if (legMatchDataForMatchStateText == null)
		{
			return;
		}
		this.RefreshMatchStateInfo(legMatchDataForMatchStateText);
	}

	// Token: 0x0601489C RID: 84124 RVA: 0x0052FC14 File Offset: 0x0052DE14
	[NullableContext(1)]
	private void RefreshWinnerInfo(RacingBetsLegMatchData legMatchData)
	{
		int championDangoId = legMatchData.GetChampionDangoId();
		DangoConfig instance = DangoConfig.Instance;
		Dango? dango = (instance != null) ? instance.GetDangoById(championDangoId) : null;
		if (dango == null)
		{
			return;
		}
		base.SetTextureByPath(dango.Value.Icon, base.GetTexture(21), null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(20), "DangoFinalChampionName", new <>z__ReadOnlySingleElementList<object>(new TableTextArgNew(dango.Value.Name, Array.Empty<object>())));
		if (!this.HasPlayedWinSequence)
		{
			this.HasPlayedWinSequence = true;
			this.WinnerSequencePlayer.PlaySequencePurely("Win", false, false, null, null, false);
		}
	}

	// Token: 0x0601489D RID: 84125 RVA: 0x0052FCD8 File Offset: 0x0052DED8
	[NullableContext(1)]
	private void RefreshMatchStateInfo(RacingBetsLegMatchData legMatchData)
	{
		RacingBetsSeasonData racingBetsSeasonData = RacingBetsModel.Instance.GetRacingBetsSeasonData();
		RacingBetsGroupMatchData parentGroupMatchData = legMatchData.ParentGroupMatchData;
		IEnumerable<RacingBetsMatch> matchTableConfigBySeasonId = RacingBetsConfig.Instance.GetMatchTableConfigBySeasonId(racingBetsSeasonData.Id);
		RacingBetsMatch? racingBetsMatch = null;
		foreach (RacingBetsMatch value in matchTableConfigBySeasonId)
		{
			int[] groupMatchListArray = value.GetGroupMatchListArray();
			bool flag = false;
			if (groupMatchListArray != null)
			{
				int[] array = groupMatchListArray;
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] == parentGroupMatchData.Id)
					{
						flag = true;
						break;
					}
				}
			}
			if (flag)
			{
				racingBetsMatch = new RacingBetsMatch?(value);
				break;
			}
		}
		if (racingBetsMatch == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RacingBets;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "赌马赛程|RacingBetsMatch未找到比赛配置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("legMatchDataId", legMatchData.Id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		base.GetText(10).ShowTextNew(racingBetsMatch.Value.Name);
		base.GetText(11).ShowTextNew(legMatchData.ShortName);
		int legMatchState = (int)legMatchData.GetLegMatchState();
		bool flag2 = RacingBetsModel.Instance.IsFinalLegMatch(legMatchData.Id);
		bool flag3 = legMatchState == 4;
		int betDangoId = legMatchData.BetDangoId;
		bool flag4 = legMatchData.BetDangoId != 0;
		string resourceId = flag4 ? "T_RaceBannerBlue" : "T_RaceBannerGreen";
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		base.SetTextureByPath(resourcePath, base.GetTexture(9), null, null);
		if (flag4)
		{
			Dango? dangoById = DangoConfig.Instance.GetDangoById(betDangoId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(14), "Dango_MainPage_BetStatus_Bet", new <>z__ReadOnlySingleElementList<object>(new TableTextArgNew(dangoById.Value.Name, Array.Empty<object>())));
		}
		else
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(14), "Dango_MainPage_BetStatus_NotBet", Array.Empty<object>());
		}
		if (flag3)
		{
			int championDangoId = legMatchData.GetChampionDangoId();
			Dango? dangoById2 = DangoConfig.Instance.GetDangoById(championDangoId);
			if (flag4)
			{
				base.SetTextureByPath(DangoConfig.Instance.GetDangoById(betDangoId).Value.Icon, base.GetTexture(13), null, null);
				bool flag5 = betDangoId == championDangoId;
				if (!flag5)
				{
					base.GetArtText(17).SetText(legMatchData.GetBetDangoRank().ToString());
				}
				base.GetItem(16).SetUIActive(!flag5);
				base.GetItem(15).SetUIActive(flag5);
			}
			else
			{
				base.SetTextureByPath(dangoById2.Value.Icon, base.GetTexture(13), null, null);
				base.GetItem(15).SetUIActive(true);
				base.GetItem(16).SetUIActive(false);
			}
			base.GetSprite(12).SetUIActive(false);
			base.GetTexture(13).SetUIActive(true);
		}
		else
		{
			if (flag4)
			{
				base.SetTextureByPath(DangoConfig.Instance.GetDangoById(betDangoId).Value.Icon, base.GetTexture(13), null, null);
			}
			base.GetItem(15).SetUIActive(false);
			base.GetItem(16).SetUIActive(false);
			base.GetTexture(13).SetUIActive(flag4);
			base.GetSprite(12).SetUIActive(!flag4);
		}
		base.GetText(18).SetText(this.RacingBetSeasonData.GetMatchStateDisplayTextForLeg(legMatchData), true);
		base.GetText(11).SetUIActive(!flag2);
	}

	// Token: 0x04009A69 RID: 39529
	private RacingBetsSeasonData RacingBetSeasonData;

	// Token: 0x04009A6A RID: 39530
	private ActivityTitleTypeA TitleItem;

	// Token: 0x04009A6B RID: 39531
	private ActivityDescriptionTypeA DescriptionItem;

	// Token: 0x04009A6C RID: 39532
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListItem;

	// Token: 0x04009A6D RID: 39533
	private ActivityFunctionalTypeA FunctionalItem;

	// Token: 0x04009A6E RID: 39534
	private ActivityButtonItem ActivityInternalRewardItem;

	// Token: 0x04009A6F RID: 39535
	private ActivityButtonItem ActivityRewardItem;

	// Token: 0x04009A70 RID: 39536
	private LevelSequencePlayer WinnerSequencePlayer;

	// Token: 0x04009A71 RID: 39537
	private bool HasPlayedWinSequence;

	// Token: 0x02008D7B RID: 36219
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x0402DE78 RID: 188024
		public const int TitleItem = 0;

		// Token: 0x0402DE79 RID: 188025
		public const int DescriptionItem = 1;

		// Token: 0x0402DE7A RID: 188026
		public const int RewardItem = 2;

		// Token: 0x0402DE7B RID: 188027
		public const int FunctionItem = 3;

		// Token: 0x0402DE7C RID: 188028
		public const int ActivityInternalRewardItem = 4;

		// Token: 0x0402DE7D RID: 188029
		public const int ActivityRewardItem = 5;

		// Token: 0x0402DE7E RID: 188030
		public const int SpineActor = 6;

		// Token: 0x0402DE7F RID: 188031
		public const int PanelInfo = 7;

		// Token: 0x0402DE80 RID: 188032
		public const int PanelMatchState = 8;

		// Token: 0x0402DE81 RID: 188033
		public const int MatchStateBgTexture = 9;

		// Token: 0x0402DE82 RID: 188034
		public const int GroupMatchNameText = 10;

		// Token: 0x0402DE83 RID: 188035
		public const int LegMatchNameText = 11;

		// Token: 0x0402DE84 RID: 188036
		public const int NoBetSprite = 12;

		// Token: 0x0402DE85 RID: 188037
		public const int DangoTexture = 13;

		// Token: 0x0402DE86 RID: 188038
		public const int BetStateText = 14;

		// Token: 0x0402DE87 RID: 188039
		public const int NoOneItem = 15;

		// Token: 0x0402DE88 RID: 188040
		public const int RankItem = 16;

		// Token: 0x0402DE89 RID: 188041
		public const int RankArtText = 17;

		// Token: 0x0402DE8A RID: 188042
		public const int MatchStateText = 18;

		// Token: 0x0402DE8B RID: 188043
		public const int PanelWinner = 19;

		// Token: 0x0402DE8C RID: 188044
		public const int WinnerText = 20;

		// Token: 0x0402DE8D RID: 188045
		public const int WinnerDangoTexture = 21;

		// Token: 0x0402DE8E RID: 188046
		public const int PanelRoleWinner = 22;
	}
}
