using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x02001655 RID: 5717
[NullableContext(1)]
[Nullable(0)]
public class WheelTowerTotalScoreSharePanel : UiPanelBase
{
	// Token: 0x0600A07E RID: 41086 RVA: 0x00235D68 File Offset: 0x00233F68
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

	// Token: 0x0600A07F RID: 41087 RVA: 0x00235EBC File Offset: 0x002340BC
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerTotalScoreSharePanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerTotalScoreSharePanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A080 RID: 41088 RVA: 0x00235EFF File Offset: 0x002340FF
	private WheelTowerShareTeamItem CreateTeamItem()
	{
		return new WheelTowerShareTeamItem();
	}

	// Token: 0x0600A081 RID: 41089 RVA: 0x00235F08 File Offset: 0x00234108
	private UniTask LoadSeasonBgItem()
	{
		WheelTowerTotalScoreSharePanel.<LoadSeasonBgItem>d__7 <LoadSeasonBgItem>d__;
		<LoadSeasonBgItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadSeasonBgItem>d__.<>4__this = this;
		<LoadSeasonBgItem>d__.<>1__state = -1;
		<LoadSeasonBgItem>d__.<>t__builder.Start<WheelTowerTotalScoreSharePanel.<LoadSeasonBgItem>d__7>(ref <LoadSeasonBgItem>d__);
		return <LoadSeasonBgItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600A082 RID: 41090 RVA: 0x00235F4C File Offset: 0x0023414C
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
		List<TeamChallengeInfo> data = (from t in teamChallengeInfos
		orderby t.TeamScore descending
		select t).Take(this.SHARE_TEAM_MAX_NUM).ToList<TeamChallengeInfo>();
		GenericLayout<WheelTowerShareTeamItem, TeamChallengeInfo> teamScrollLayout = this.TeamScrollLayout;
		if (teamScrollLayout != null)
		{
			teamScrollLayout.RefreshByData(data, null, false);
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

	// Token: 0x0600A083 RID: 41091 RVA: 0x002361A8 File Offset: 0x002343A8
	protected override void OnFinishShow()
	{
		WheelTowerSeasonBgItem seasonBgItem = this.SeasonBgItem;
		if (seasonBgItem == null)
		{
			return;
		}
		seasonBgItem.StopAllTweenAndSpine();
	}

	// Token: 0x0600A084 RID: 41092 RVA: 0x002361BA File Offset: 0x002343BA
	public AActor GetBlurOverrideActor()
	{
		AUIBaseActor rootActor = this.RootActor;
		return (((rootActor != null) ? rootActor.GetComponentByClass(TsUiBlur.StaticClass()) : null) as TsUiBlur).OverrideItem;
	}

	// Token: 0x0400493C RID: 18748
	private int SHARE_TEAM_MAX_NUM = 5;

	// Token: 0x0400493D RID: 18749
	public GenericLayout<WheelTowerShareTeamItem, TeamChallengeInfo> TeamScrollLayout;

	// Token: 0x0400493E RID: 18750
	private WheelTowerSeasonBgItem SeasonBgItem;

	// Token: 0x02007C15 RID: 31765
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04028BD9 RID: 166873
		BgItem,
		// Token: 0x04028BDA RID: 166874
		TextSeasonTitle,
		// Token: 0x04028BDB RID: 166875
		SeasonTexture,
		// Token: 0x04028BDC RID: 166876
		TextureScoreLevel,
		// Token: 0x04028BDD RID: 166877
		TextScore,
		// Token: 0x04028BDE RID: 166878
		TextBossTurn,
		// Token: 0x04028BDF RID: 166879
		TextBossProgress,
		// Token: 0x04028BE0 RID: 166880
		ScrollViewTeam,
		// Token: 0x04028BE1 RID: 166881
		ScrollViewTeamItem,
		// Token: 0x04028BE2 RID: 166882
		TeamNum
	}
}
