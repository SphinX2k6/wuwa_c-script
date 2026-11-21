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

// Token: 0x02000B03 RID: 2819
[NullableContext(1)]
[Nullable(0)]
public class WheelTowerSettlementShareView : UiPanelBase
{
	// Token: 0x0600741A RID: 29722 RVA: 0x0023E260 File Offset: 0x0023C460
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

	// Token: 0x0600741B RID: 29723 RVA: 0x0023E390 File Offset: 0x0023C590
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerSettlementShareView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerSettlementShareView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600741C RID: 29724 RVA: 0x0023E3D3 File Offset: 0x0023C5D3
	private WheelTowerSettlementRoleItem CreateRoleItem()
	{
		return new WheelTowerSettlementRoleItem();
	}

	// Token: 0x0600741D RID: 29725 RVA: 0x0023E3DC File Offset: 0x0023C5DC
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

	// Token: 0x0600741E RID: 29726 RVA: 0x0023E564 File Offset: 0x0023C764
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

	// Token: 0x040049A5 RID: 18853
	private WheelTowerModeSettlementTitleItem ModeTitleItem;

	// Token: 0x040049A6 RID: 18854
	private WheelTowerSettlementRoundPanel RoundPanel;

	// Token: 0x040049A7 RID: 18855
	private WheelTowerSettlementScorePanel ScorePanel;

	// Token: 0x040049A8 RID: 18856
	private WheelTowerSettlementBossResultPanel BossResultPanel;

	// Token: 0x040049A9 RID: 18857
	private GenericLayout<WheelTowerSettlementRoleItem, RoleDataWithBranch> RoleLayout;

	// Token: 0x02006D93 RID: 28051
	[NullableContext(0)]
	private enum EComp
	{
		// Token: 0x04023EE5 RID: 147173
		BgModeTitle,
		// Token: 0x04023EE6 RID: 147174
		BgRoundPoints,
		// Token: 0x04023EE7 RID: 147175
		BgScore,
		// Token: 0x04023EE8 RID: 147176
		BgBattleBoss,
		// Token: 0x04023EE9 RID: 147177
		RoleLayout,
		// Token: 0x04023EEA RID: 147178
		RoleItem,
		// Token: 0x04023EEB RID: 147179
		SeasonTexture,
		// Token: 0x04023EEC RID: 147180
		CharacterBg
	}
}
