using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001589 RID: 5513
public class WheelTowerBossHandBookButtonItem : UiPanelBase
{
	// Token: 0x06009D5A RID: 40282 RVA: 0x00221B28 File Offset: 0x0021FD28
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

	// Token: 0x06009D5B RID: 40283 RVA: 0x00221BD0 File Offset: 0x0021FDD0
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

	// Token: 0x06009D5C RID: 40284 RVA: 0x00221BFF File Offset: 0x0021FDFF
	public void SetJumpInfo(int waveId, int teamRound, bool isEndless)
	{
		this.JumpWaveConfigId = waveId;
		this.JumpTeamRound = teamRound;
		this.JumpEndless = isEndless;
	}

	// Token: 0x06009D5D RID: 40285 RVA: 0x00221C18 File Offset: 0x0021FE18
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

	// Token: 0x04004524 RID: 17700
	private int JumpWaveConfigId;

	// Token: 0x04004525 RID: 17701
	private int JumpTeamRound;

	// Token: 0x04004526 RID: 17702
	private bool JumpEndless;
}
