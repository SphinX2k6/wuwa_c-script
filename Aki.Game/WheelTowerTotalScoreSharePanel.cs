using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower.View.Season;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf.Collections;
using UnrealEngine;

// Token: 0x02000B0D RID: 2829
[NullableContext(1)]
[Nullable(0)]
public class WheelTowerTotalScoreSharePanel : UiPanelBase
{
	// Token: 0x0600745C RID: 29788 RVA: 0x0023FBA4 File Offset: 0x0023DDA4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUILayoutBase));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600745D RID: 29789 RVA: 0x0023FCF8 File Offset: 0x0023DEF8
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerTotalScoreSharePanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerTotalScoreSharePanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600745E RID: 29790 RVA: 0x0023FD3B File Offset: 0x0023DF3B
	private WheelTowerShareTeamItem CreateTeamItem()
	{
		return new WheelTowerShareTeamItem();
	}

	// Token: 0x0600745F RID: 29791 RVA: 0x0023FD44 File Offset: 0x0023DF44
	private UniTask LoadSeasonBgItem()
	{
		WheelTowerTotalScoreSharePanel.<LoadSeasonBgItem>d__7 <LoadSeasonBgItem>d__;
		<LoadSeasonBgItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadSeasonBgItem>d__.<>4__this = this;
		<LoadSeasonBgItem>d__.<>1__state = -1;
		<LoadSeasonBgItem>d__.<>t__builder.Start<WheelTowerTotalScoreSharePanel.<LoadSeasonBgItem>d__7>(ref <LoadSeasonBgItem>d__);
		return <LoadSeasonBgItem>d__.<>t__builder.Task;
	}

	// Token: 0x06007460 RID: 29792 RVA: 0x0023FD88 File Offset: 0x0023DF88
	protected override void OnStart()
	{
		WheelTowerSeasonBgItem seasonBgItem = this.SeasonBgItem;
		if (seasonBgItem != null)
		{
			seasonBgItem.GetSequencePlayer().PlaySequence("Start", false, null);
		}
		int maxChallengeRound = WheelTowerModel.Instance.GetMaxChallengeRound(null);
		ValueTuple<int, int> bossProgress = WheelTowerModel.Instance.GetBossProgress(maxChallengeRound, null);
		int item = bossProgress.Item1;
		int item2 = bossProgress.Item2;
		MonsterInfoPreview bossInfoByRound = WheelTowerModel.Instance.GetBossInfoByRound(maxChallengeRound, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "Share_NewTowerTotal_1002", new <>z__ReadOnlySingleElementList<object>(bossInfoByRound.Round));
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), "Share_NewTowerTotal_1003", new <>z__ReadOnlyArray<object>(new object[]
		{
			item,
			item2
		}));
		int totalScore = WheelTowerModel.Instance.GetTotalScore();
		UUIText text = base.GetText(4);
		if (text != null)
		{
			text.SetText(totalScore.ToString(), true);
		}
		RepeatedField<TeamChallengeInfo> teamChallengeInfos = WheelTowerModel.Instance.GetCurrentLevelRecord(null).TeamChallengeInfos;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(9), "Share_NewTowerTotal_1001", new <>z__ReadOnlySingleElementList<object>(teamChallengeInfos.Count.ToString()));
		List<TeamChallengeInfo> list = new List<TeamChallengeInfo>(this.SHARE_TEAM_MAX_NUM);
		foreach (TeamChallengeInfo teamChallengeInfo in teamChallengeInfos)
		{
			int num = list.Count;
			while (num > 0 && list[num - 1].TeamScore < teamChallengeInfo.TeamScore)
			{
				num--;
			}
			if (num < this.SHARE_TEAM_MAX_NUM)
			{
				list.Insert(num, teamChallengeInfo);
				if (list.Count > this.SHARE_TEAM_MAX_NUM)
				{
					list.RemoveAt(this.SHARE_TEAM_MAX_NUM);
				}
			}
		}
		GenericLayout<WheelTowerShareTeamItem, TeamChallengeInfo> teamScrollLayout = this.TeamScrollLayout;
		if (teamScrollLayout != null)
		{
			teamScrollLayout.RefreshByData(list, null, false);
		}
		int seasonId = WheelTowerModel.Instance.ActivityData.SeasonId;
		if (seasonId != 0)
		{
			NewTowerSeason? seasonConfig = WheelTowerConfig.Instance.GetSeasonConfig(seasonId);
			base.SetTextureByPath(seasonConfig.Value.VersionIconMain, base.GetTexture(2), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), seasonConfig.Value.Name, Array.Empty<object>());
		}
		EScoreLevel totalScoreLevel = WheelTowerModel.Instance.GetTotalScoreLevel(totalScore, null, null);
		base.SetTextureByPath(WheelTowerConfig.Instance.GetScoreLevelConfigById((int)totalScoreLevel).Value.Icon, base.GetTexture(3), null, null);
	}

	// Token: 0x06007461 RID: 29793 RVA: 0x00240054 File Offset: 0x0023E254
	protected override void OnFinishShow()
	{
		WheelTowerSeasonBgItem seasonBgItem = this.SeasonBgItem;
		if (seasonBgItem == null)
		{
			return;
		}
		seasonBgItem.StopAllTweenAndSpine();
	}

	// Token: 0x06007462 RID: 29794 RVA: 0x00240066 File Offset: 0x0023E266
	public AActor GetBlurOverrideActor()
	{
		AUIBaseActor rootActor = this.RootActor;
		return (((rootActor != null) ? rootActor.GetComponentByClass(TsUiBlur.StaticClass()) : null) as TsUiBlur).OverrideItem;
	}

	// Token: 0x040049E2 RID: 18914
	private int SHARE_TEAM_MAX_NUM = 5;

	// Token: 0x040049E3 RID: 18915
	public GenericLayout<WheelTowerShareTeamItem, TeamChallengeInfo> TeamScrollLayout;

	// Token: 0x040049E4 RID: 18916
	private WheelTowerSeasonBgItem SeasonBgItem;

	// Token: 0x02006D9D RID: 28061
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04023F0C RID: 147212
		BgItem,
		// Token: 0x04023F0D RID: 147213
		TextSeasonTitle,
		// Token: 0x04023F0E RID: 147214
		SeasonTexture,
		// Token: 0x04023F0F RID: 147215
		TextureScoreLevel,
		// Token: 0x04023F10 RID: 147216
		TextScore,
		// Token: 0x04023F11 RID: 147217
		TextBossTurn,
		// Token: 0x04023F12 RID: 147218
		TextBossProgress,
		// Token: 0x04023F13 RID: 147219
		ScrollViewTeam,
		// Token: 0x04023F14 RID: 147220
		ScrollViewTeamItem,
		// Token: 0x04023F15 RID: 147221
		TeamNum
	}
}
