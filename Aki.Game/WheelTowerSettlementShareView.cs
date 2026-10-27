using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200164B RID: 5707
[NullableContext(1)]
[Nullable(0)]
public class WheelTowerSettlementShareView : UiPanelBase
{
	// Token: 0x0600A03C RID: 41020 RVA: 0x00234424 File Offset: 0x00232624
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
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
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600A03D RID: 41021 RVA: 0x00234554 File Offset: 0x00232754
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerSettlementShareView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerSettlementShareView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A03E RID: 41022 RVA: 0x00234597 File Offset: 0x00232797
	private WheelTowerSettlementRoleItem CreateRoleItem()
	{
		return new WheelTowerSettlementRoleItem();
	}

	// Token: 0x0600A03F RID: 41023 RVA: 0x002345A0 File Offset: 0x002327A0
	protected override void OnStart()
	{
		IWheelTowerSettlementViewData wheelTowerSettlementViewData = this.OpenParam as IWheelTowerSettlementViewData;
		ValueTuple<int, int> bossRoundAndWave = this.GetBossRoundAndWave(wheelTowerSettlementViewData.BossInfoList);
		int item = bossRoundAndWave.Item1;
		int num = bossRoundAndWave.Item2 % wheelTowerSettlementViewData.MaxBossWaveNum;
		int curBossWave = (num != 0) ? num : wheelTowerSettlementViewData.MaxBossWaveNum;
		EScoreLevel totalScoreLevel = WheelTowerModel.Instance.GetTotalScoreLevel(wheelTowerSettlementViewData.TotalScore, null, null);
		WheelTowerModeSettlementTitleItem modeTitleItem = this.ModeTitleItem;
		if (modeTitleItem != null)
		{
			modeTitleItem.Refresh(wheelTowerSettlementViewData.EndlessMode);
		}
		WheelTowerSettlementRoundPanel roundPanel = this.RoundPanel;
		if (roundPanel != null)
		{
			roundPanel.RefreshRoundScore(wheelTowerSettlementViewData.CurrentScore);
		}
		WheelTowerSettlementScorePanel scorePanel = this.ScorePanel;
		if (scorePanel != null)
		{
			scorePanel.RefreshTotalScore(wheelTowerSettlementViewData.TotalScore);
		}
		WheelTowerSettlementScorePanel scorePanel2 = this.ScorePanel;
		if (scorePanel2 != null)
		{
			scorePanel2.RefreshScoreLevel((int)totalScoreLevel);
		}
		WheelTowerSettlementScorePanel scorePanel3 = this.ScorePanel;
		if (scorePanel3 != null)
		{
			scorePanel3.RefreshRoundWave(wheelTowerSettlementViewData.EndlessMode, item, curBossWave, wheelTowerSettlementViewData.MaxBossWaveNum);
		}
		WheelTowerSettlementBossResultPanel bossResultPanel = this.BossResultPanel;
		if (bossResultPanel != null)
		{
			bossResultPanel.Refresh(wheelTowerSettlementViewData.BossInfoList);
		}
		GenericLayout<WheelTowerSettlementRoleItem, RoleDataWithBranch> roleLayout = this.RoleLayout;
		if (roleLayout != null)
		{
			roleLayout.RefreshByData(wheelTowerSettlementViewData.RoleList, null, false);
		}
		int num2 = wheelTowerSettlementViewData.RoleList[0].RoleId;
		if (WheelTowerModel.Instance.IsTemplateRole(num2))
		{
			num2 = WheelTowerModel.Instance.GetRealRoleId(num2);
		}
		base.SetTextureByPath(ConfigGaChaShareById.GetConfig(num2, true).Value.SharePic, base.GetTexture(7), null, null);
		WheelTowerSettlementBossResultPanel bossResultPanel2 = this.BossResultPanel;
		if (bossResultPanel2 == null)
		{
			return;
		}
		bossResultPanel2.SetBossScrollEnable(false);
	}

	// Token: 0x0600A040 RID: 41024 RVA: 0x00234728 File Offset: 0x00232928
	[NullableContext(0)]
	[return: TupleElementNames(new string[]
	{
		"bossRound",
		"product"
	})]
	private ValueTuple<int, int> GetBossRoundAndWave([Nullable(1)] List<IBossItemData> bossInfoList)
	{
		int num = 1;
		int item = 0;
		foreach (IBossItemData bossItemData in bossInfoList)
		{
			if (bossItemData.BossInfo.Round > num)
			{
				num = bossItemData.BossInfo.Round;
			}
			item = WheelTowerConfig.Instance.GetWaveConfigById(bossItemData.BossInfo.WaveConfigId).Value.Wave;
		}
		return new ValueTuple<int, int>(num, item);
	}

	// Token: 0x040048FF RID: 18687
	private WheelTowerModeSettlementTitleItem ModeTitleItem;

	// Token: 0x04004900 RID: 18688
	private WheelTowerSettlementRoundPanel RoundPanel;

	// Token: 0x04004901 RID: 18689
	private WheelTowerSettlementScorePanel ScorePanel;

	// Token: 0x04004902 RID: 18690
	private WheelTowerSettlementBossResultPanel BossResultPanel;

	// Token: 0x04004903 RID: 18691
	private GenericLayout<WheelTowerSettlementRoleItem, RoleDataWithBranch> RoleLayout;

	// Token: 0x02007C0B RID: 31755
	[NullableContext(0)]
	private enum EComp
	{
		// Token: 0x04028BB2 RID: 166834
		BgModeTitle,
		// Token: 0x04028BB3 RID: 166835
		BgRoundPoints,
		// Token: 0x04028BB4 RID: 166836
		BgScore,
		// Token: 0x04028BB5 RID: 166837
		BgBattleBoss,
		// Token: 0x04028BB6 RID: 166838
		RoleLayout,
		// Token: 0x04028BB7 RID: 166839
		RoleItem,
		// Token: 0x04028BB8 RID: 166840
		SeasonTexture,
		// Token: 0x04028BB9 RID: 166841
		CharacterBg
	}
}
