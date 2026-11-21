using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001193 RID: 4499
[NullableContext(2)]
[Nullable(0)]
public class MotorcycleArrowBattleMain : BattleChildViewPanel
{
	// Token: 0x0600B377 RID: 45943 RVA: 0x003509C8 File Offset: 0x0034EBC8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(9, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(8, new Action(this.OnButtonStopClicked))
		};
	}

	// Token: 0x0600B378 RID: 45944 RVA: 0x00350AE0 File Offset: 0x0034ECE0
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleArrowBattleMain.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleArrowBattleMain.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B379 RID: 45945 RVA: 0x00350B24 File Offset: 0x0034ED24
	protected override void OnBeforeDestroy()
	{
		this.OnRemoveEventListener();
		UUIItem saveItem = this.SaveItem;
		if (saveItem != null)
		{
			saveItem.SetUIActive(false);
		}
		if (this.HideSaveTimer != null && TimerSystem.GameplayTimeInstance.Has(this.HideSaveTimer))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.HideSaveTimer);
		}
	}

	// Token: 0x0600B37A RID: 45946 RVA: 0x00350B74 File Offset: 0x0034ED74
	protected void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.MotorArrowBossHpChange, new Action<FKSC_HeadHpContext>(this.OnMotorArrowBossHpChange));
		EventSystem.Instance.Add(EEventName.MotorArrowBossCreate, new Action<string>(this.OnMotorArrowBossCreate));
		EventSystem.Instance.Add(EEventName.LevelGamePlayPrepareCountDownEnd, new Action(this.OnCountDownEnd));
		EventSystem.Instance.Add(EEventName.MotorArrowSave, new Action(this.OnSave));
	}

	// Token: 0x0600B37B RID: 45947 RVA: 0x00350BF4 File Offset: 0x0034EDF4
	protected void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.MotorArrowBossHpChange, new Action<FKSC_HeadHpContext>(this.OnMotorArrowBossHpChange));
		EventSystem.Instance.Remove(EEventName.MotorArrowBossCreate, new Action<string>(this.OnMotorArrowBossCreate));
		EventSystem.Instance.Remove(EEventName.LevelGamePlayPrepareCountDownEnd, new Action(this.OnCountDownEnd));
		EventSystem.Instance.Remove(EEventName.MotorArrowSave, new Action(this.OnSave));
	}

	// Token: 0x0600B37C RID: 45948 RVA: 0x00350C74 File Offset: 0x0034EE74
	private void OnCountDownEnd()
	{
		this.ButtonStop.RootUIComp.Get().SetUIActive(true);
		this.ScoreItem.ShowAsync().Forget<bool>();
		this.BattleProgressItem.ShowAsync().Forget<bool>();
		this.HpPlayerItem.ShowAsync().Forget<bool>();
		MotorcycleControlPanelBase motorcycleControlPanel = this.MotorcycleControlPanel;
		if (motorcycleControlPanel == null)
		{
			return;
		}
		motorcycleControlPanel.ShowBattleVisibleChildView(false);
	}

	// Token: 0x0600B37D RID: 45949 RVA: 0x00350CDC File Offset: 0x0034EEDC
	[NullableContext(1)]
	private void OnMotorArrowBossHpChange(FKSC_HeadHpContext headInfo)
	{
		if (headInfo.ActionType == EKSC_HeadHpContextType.Remove)
		{
			MotorcycleArrowBossHpItem bossHpItem = this.BossHpItem;
			if (bossHpItem != null)
			{
				bossHpItem.SetActive(false);
			}
			SimpleBossStateItem bossHpItem2 = this.BossHpItem2;
			if (bossHpItem2 == null)
			{
				return;
			}
			bossHpItem2.SetActive(false);
			return;
		}
		else
		{
			MotorcycleArrowBossHpItem bossHpItem3 = this.BossHpItem;
			if (bossHpItem3 == null || !bossHpItem3.GetActive())
			{
				MotorcycleArrowBossHpItem bossHpItem4 = this.BossHpItem;
				if (bossHpItem4 != null)
				{
					bossHpItem4.SetActive(true);
				}
				SimpleBossStateItem bossHpItem5 = this.BossHpItem2;
				if (bossHpItem5 != null)
				{
					bossHpItem5.SetActive(true);
				}
				MotorcycleArrowBossHpItem bossHpItem6 = this.BossHpItem;
				if (bossHpItem6 != null)
				{
					bossHpItem6.UpdateHeadStateInfo(headInfo, false);
				}
				SimpleBossStateItem bossHpItem7 = this.BossHpItem2;
				if (bossHpItem7 != null)
				{
					bossHpItem7.RefreshBossInfo(headInfo);
				}
			}
			MotorcycleArrowBossHpItem bossHpItem8 = this.BossHpItem;
			if (bossHpItem8 != null)
			{
				bossHpItem8.UpdateHeadStateInfo(headInfo, true);
			}
			SimpleBossStateItem bossHpItem9 = this.BossHpItem2;
			if (bossHpItem9 == null)
			{
				return;
			}
			bossHpItem9.UpdateHeadStateInfo(headInfo);
			return;
		}
	}

	// Token: 0x0600B37E RID: 45950 RVA: 0x00350D9A File Offset: 0x0034EF9A
	[NullableContext(1)]
	private void OnMotorArrowBossCreate(string bossName)
	{
		SimpleBossStateItem bossHpItem = this.BossHpItem2;
		if (bossHpItem == null)
		{
			return;
		}
		bossHpItem.SetBossName(bossName);
	}

	// Token: 0x0600B37F RID: 45951 RVA: 0x00350DB0 File Offset: 0x0034EFB0
	public override void OnTickBattleChildViewPanel(float delta)
	{
		MotorcycleArrowBattleProgressItem battleProgressItem = this.BattleProgressItem;
		if (battleProgressItem != null)
		{
			battleProgressItem.OnTick(delta);
		}
		MotorcycleArrowScore scoreItem = this.ScoreItem;
		if (scoreItem != null)
		{
			scoreItem.OnTick(delta);
		}
		MotorcycleArrowHpPlayerItem hpPlayerItem = this.HpPlayerItem;
		if (hpPlayerItem != null)
		{
			hpPlayerItem.OnTick(delta);
		}
		MotorcycleControlPanelBase motorcycleControlPanel = this.MotorcycleControlPanel;
		if (motorcycleControlPanel != null)
		{
			motorcycleControlPanel.Tick(delta);
		}
		MotorcycleArrowBossHpItem bossHpItem = this.BossHpItem;
		if (bossHpItem != null && bossHpItem.GetActive())
		{
			MotorcycleArrowBossHpItem bossHpItem2 = this.BossHpItem;
			if (bossHpItem2 != null)
			{
				bossHpItem2.OnTick(delta);
			}
			SimpleBossStateItem bossHpItem3 = this.BossHpItem2;
			if (bossHpItem3 == null)
			{
				return;
			}
			bossHpItem3.OnTick(delta);
		}
	}

	// Token: 0x0600B380 RID: 45952 RVA: 0x00350E3C File Offset: 0x0034F03C
	protected override void OnStart()
	{
	}

	// Token: 0x0600B381 RID: 45953 RVA: 0x00350E3E File Offset: 0x0034F03E
	private void OnButtonStopClicked()
	{
		UiManager.Instance.OpenView(EUiViewName.MotorFightPauseView, null, null);
	}

	// Token: 0x0600B382 RID: 45954 RVA: 0x00350E54 File Offset: 0x0034F054
	private void OnSave()
	{
		if (this.HideSaveTimer != null && TimerSystem.GameplayTimeInstance.Has(this.HideSaveTimer))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.HideSaveTimer);
		}
		UUIItem saveItem = this.SaveItem;
		if (saveItem != null)
		{
			saveItem.SetUIActive(true);
		}
		this.HideSaveTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			this.HideSaveTimer = null;
			UUIItem saveItem2 = this.SaveItem;
			if (saveItem2 == null)
			{
				return;
			}
			saveItem2.SetUIActive(false);
		}, (float)this.ShowSaveDuration / 1000f, null, null, true, 1f);
	}

	// Token: 0x04006799 RID: 26521
	protected MotorcycleArrowHpPlayerItem HpPlayerItem;

	// Token: 0x0400679A RID: 26522
	protected MotorcycleArrowBattleProgressItem BattleProgressItem;

	// Token: 0x0400679B RID: 26523
	protected MotorcycleArrowScore ScoreItem;

	// Token: 0x0400679C RID: 26524
	protected MotorcycleArrowBossHpItem BossHpItem;

	// Token: 0x0400679D RID: 26525
	protected SimpleBossStateItem BossHpItem2;

	// Token: 0x0400679E RID: 26526
	protected UUIItem SaveItem;

	// Token: 0x0400679F RID: 26527
	private TimerHandle HideSaveTimer;

	// Token: 0x040067A0 RID: 26528
	protected UUIButtonComponent ButtonControlL;

	// Token: 0x040067A1 RID: 26529
	protected UUIButtonComponent ButtonControlR;

	// Token: 0x040067A2 RID: 26530
	protected UUIButtonComponent ButtonStop;

	// Token: 0x040067A3 RID: 26531
	private MotorcycleControlPanelBase MotorcycleControlPanel;

	// Token: 0x040067A4 RID: 26532
	private int ShowSaveDuration;

	// Token: 0x0200745C RID: 29788
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04025E16 RID: 155158
		public const int BattleProgress = 0;

		// Token: 0x04025E17 RID: 155159
		public const int BattleHpPlayer = 1;

		// Token: 0x04025E18 RID: 155160
		public const int Score = 2;

		// Token: 0x04025E19 RID: 155161
		public const int Save = 3;

		// Token: 0x04025E1A RID: 155162
		public const int Skill = 4;

		// Token: 0x04025E1B RID: 155163
		public const int ButtonControlL = 5;

		// Token: 0x04025E1C RID: 155164
		public const int ButtonControlR = 6;

		// Token: 0x04025E1D RID: 155165
		public const int BossHp = 7;

		// Token: 0x04025E1E RID: 155166
		public const int ButtonStop = 8;

		// Token: 0x04025E1F RID: 155167
		public const int ButtonControlRoot = 9;
	}
}
