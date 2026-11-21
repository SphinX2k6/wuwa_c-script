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

// Token: 0x02001C0F RID: 7183
[NullableContext(2)]
[Nullable(0)]
public class RacingBetsActivityView : ActivitySubViewBase
{
	// Token: 0x06011D6D RID: 73069 RVA: 0x0053E169 File Offset: 0x0053C369
	protected override void OnSetData()
	{
		this.RacingBetSeasonData = (this.ActivityBaseData as RacingBetsSeasonData);
	}

	// Token: 0x06011D6E RID: 73070 RVA: 0x0053E17C File Offset: 0x0053C37C
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnRacingBetsPlayerInfoUpdate, new Action(this.RefreshPlayerBetInfo));
		EventSystem.Instance.Add(EEventName.OnRacingBetsRewardRefresh, new Action(this.RefreshRedDot));
	}

	// Token: 0x06011D6F RID: 73071 RVA: 0x0053E1B6 File Offset: 0x0053C3B6
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnRacingBetsPlayerInfoUpdate, new Action(this.RefreshPlayerBetInfo));
		EventSystem.Instance.Remove(EEventName.OnRacingBetsRewardRefresh, new Action(this.RefreshRedDot));
	}

	// Token: 0x06011D70 RID: 73072 RVA: 0x0053E1F0 File Offset: 0x0053C3F0
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

	// Token: 0x06011D71 RID: 73073 RVA: 0x0053E520 File Offset: 0x0053C720
	protected override UniTask OnBeforeStartAsync()
	{
		RacingBetsActivityView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RacingBetsActivityView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011D72 RID: 73074 RVA: 0x0053E564 File Offset: 0x0053C764
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

	// Token: 0x06011D73 RID: 73075 RVA: 0x0053E6ED File Offset: 0x0053C8ED
	protected override void OnBeforeShow()
	{
		base.GetSpine(6).SetAnimation(0, "start", false).AnimationComplete.Add(delegate(UTrackEntry _)
		{
			base.GetSpine(6).SetAnimation(0, "idle", true);
		});
	}

	// Token: 0x06011D74 RID: 73076 RVA: 0x0053E718 File Offset: 0x0053C918
	protected override void OnBeforeHide()
	{
		base.GetSpine(6).ClearTracks();
	}

	// Token: 0x06011D75 RID: 73077 RVA: 0x0053E728 File Offset: 0x0053C928
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

	// Token: 0x06011D76 RID: 73078 RVA: 0x0053E7AC File Offset: 0x0053C9AC
	protected override void OnTimer(float gap)
	{
		this.RefreshActivityTimerText();
		this.RefreshPanelInfo();
	}

	// Token: 0x06011D77 RID: 73079 RVA: 0x0053E7BC File Offset: 0x0053C9BC
	private void RefreshActivityTimerText()
	{
		string item = this.GetTimeVisibleAndRemainTime().Item2;
		this.TitleItem.SetTimeTextByText(item);
	}

	// Token: 0x06011D78 RID: 73080 RVA: 0x0053E7E1 File Offset: 0x0053C9E1
	private void RefreshRedDot()
	{
		this.FunctionalItem.FunctionButton.SetRedDotVisible(this.RacingBetSeasonData.RedPointShowState);
	}

	// Token: 0x06011D79 RID: 73081 RVA: 0x0053E7FE File Offset: 0x0053C9FE
	private void RefreshPlayerBetInfo()
	{
	}

	// Token: 0x06011D7A RID: 73082 RVA: 0x0053E800 File Offset: 0x0053CA00
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

	// Token: 0x06011D7B RID: 73083 RVA: 0x0053E820 File Offset: 0x0053CA20
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

	// Token: 0x06011D7C RID: 73084 RVA: 0x0053E86C File Offset: 0x0053CA6C
	private void OnClickActivityInternalRewardItem()
	{
		RacingBetsGroupRewardData groupRewardData = this.RacingBetSeasonData.GetGroupRewardData(ERacingBetsRewardType.DailyGameEarn);
		UiManager.Instance.OpenView(EUiViewName.RacingBetsRewardView, new List<RacingBetsGroupRewardData>
		{
			groupRewardData
		}, null);
	}

	// Token: 0x06011D7D RID: 73085 RVA: 0x0053E8A4 File Offset: 0x0053CAA4
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

	// Token: 0x06011D7E RID: 73086 RVA: 0x0053E930 File Offset: 0x0053CB30
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

	// Token: 0x06011D7F RID: 73087 RVA: 0x0053E9F4 File Offset: 0x0053CBF4
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

	// Token: 0x04009BC1 RID: 39873
	private RacingBetsSeasonData RacingBetSeasonData;

	// Token: 0x04009BC2 RID: 39874
	private ActivityTitleTypeA TitleItem;

	// Token: 0x04009BC3 RID: 39875
	private ActivityDescriptionTypeA DescriptionItem;

	// Token: 0x04009BC4 RID: 39876
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListItem;

	// Token: 0x04009BC5 RID: 39877
	private ActivityFunctionalTypeA FunctionalItem;

	// Token: 0x04009BC6 RID: 39878
	private ActivityButtonItem ActivityInternalRewardItem;

	// Token: 0x04009BC7 RID: 39879
	private ActivityButtonItem ActivityRewardItem;

	// Token: 0x04009BC8 RID: 39880
	private LevelSequencePlayer WinnerSequencePlayer;

	// Token: 0x04009BC9 RID: 39881
	private bool HasPlayedWinSequence;

	// Token: 0x02007F04 RID: 32516
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x0402918F RID: 168335
		public const int TitleItem = 0;

		// Token: 0x04029190 RID: 168336
		public const int DescriptionItem = 1;

		// Token: 0x04029191 RID: 168337
		public const int RewardItem = 2;

		// Token: 0x04029192 RID: 168338
		public const int FunctionItem = 3;

		// Token: 0x04029193 RID: 168339
		public const int ActivityInternalRewardItem = 4;

		// Token: 0x04029194 RID: 168340
		public const int ActivityRewardItem = 5;

		// Token: 0x04029195 RID: 168341
		public const int SpineActor = 6;

		// Token: 0x04029196 RID: 168342
		public const int PanelInfo = 7;

		// Token: 0x04029197 RID: 168343
		public const int PanelMatchState = 8;

		// Token: 0x04029198 RID: 168344
		public const int MatchStateBgTexture = 9;

		// Token: 0x04029199 RID: 168345
		public const int GroupMatchNameText = 10;

		// Token: 0x0402919A RID: 168346
		public const int LegMatchNameText = 11;

		// Token: 0x0402919B RID: 168347
		public const int NoBetSprite = 12;

		// Token: 0x0402919C RID: 168348
		public const int DangoTexture = 13;

		// Token: 0x0402919D RID: 168349
		public const int BetStateText = 14;

		// Token: 0x0402919E RID: 168350
		public const int NoOneItem = 15;

		// Token: 0x0402919F RID: 168351
		public const int RankItem = 16;

		// Token: 0x040291A0 RID: 168352
		public const int RankArtText = 17;

		// Token: 0x040291A1 RID: 168353
		public const int MatchStateText = 18;

		// Token: 0x040291A2 RID: 168354
		public const int PanelWinner = 19;

		// Token: 0x040291A3 RID: 168355
		public const int WinnerText = 20;

		// Token: 0x040291A4 RID: 168356
		public const int WinnerDangoTexture = 21;

		// Token: 0x040291A5 RID: 168357
		public const int PanelRoleWinner = 22;
	}
}
