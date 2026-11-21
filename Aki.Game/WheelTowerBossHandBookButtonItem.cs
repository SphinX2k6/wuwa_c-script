using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000A41 RID: 2625
public class WheelTowerBossHandBookButtonItem : UiPanelBase
{
	// Token: 0x06007138 RID: 28984 RVA: 0x0022B8D8 File Offset: 0x00229AD8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBossHandBookBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06007139 RID: 28985 RVA: 0x0022B980 File Offset: 0x00229B80
	public void RefreshRedDot()
	{
		bool uiactive = WheelTowerModel.Instance.ActivityData.HasBossHandBookRedDot();
		UUISprite sprite = base.GetSprite(1);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(uiactive);
	}

	// Token: 0x0600713A RID: 28986 RVA: 0x0022B9AF File Offset: 0x00229BAF
	public void SetJumpInfo(int waveId, int teamRound, bool isEndless)
	{
		this.JumpWaveConfigId = waveId;
		this.JumpTeamRound = teamRound;
		this.JumpEndless = isEndless;
	}

	// Token: 0x0600713B RID: 28987 RVA: 0x0022B9C8 File Offset: 0x00229BC8
	private void OnBossHandBookBtnClick()
	{
		NewTowerWave? waveConfigById = WheelTowerConfig.Instance.GetWaveConfigById(this.JumpWaveConfigId);
		if (waveConfigById == null)
		{
			return;
		}
		WheelTowerBossHandBookViewData param = new WheelTowerBossHandBookViewData
		{
			IsEndless = this.JumpEndless,
			BossId = waveConfigById.Value.MonsterId,
			BossRound = waveConfigById.Value.Round,
			TeamRound = (this.JumpEndless ? this.JumpTeamRound : 0)
		};
		UiManager.Instance.OpenView(EUiViewName.WheelTowerBossHandBookView, param, null);
		WheelTowerModel.Instance.ActivityData.RecordOpenBossHandBook();
		this.RefreshRedDot();
	}

	// Token: 0x040045CA RID: 17866
	private int JumpWaveConfigId;

	// Token: 0x040045CB RID: 17867
	private int JumpTeamRound;

	// Token: 0x040045CC RID: 17868
	private bool JumpEndless;
}
