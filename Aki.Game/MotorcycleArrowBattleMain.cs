using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001CD1 RID: 7377
[NullableContext(2)]
[Nullable(0)]
public class MotorcycleArrowBattleMain : BattleChildViewPanel
{
	// Token: 0x0600DF5A RID: 57178 RVA: 0x00344FA0 File Offset: 0x003431A0
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

	// Token: 0x0600DF5B RID: 57179 RVA: 0x003450B8 File Offset: 0x003432B8
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleArrowBattleMain.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleArrowBattleMain.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DF5C RID: 57180 RVA: 0x003450FC File Offset: 0x003432FC
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

	// Token: 0x0600DF5D RID: 57181 RVA: 0x0034514C File Offset: 0x0034334C
	protected void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.MotorArrowBossHpChange, new Action<FKSC_HeadHpContext>(this.OnMotorArrowBossHpChange));
		EventSystem.Instance.Add(EEventName.MotorArrowBossCreate, new Action<string>(this.OnMotorArrowBossCreate));
		EventSystem.Instance.Add(EEventName.LevelGamePlayPrepareCountDownEnd, new Action(this.OnCountDownEnd));
		EventSystem.Instance.Add(EEventName.MotorArrowSave, new Action(this.OnSave));
	}

	// Token: 0x0600DF5E RID: 57182 RVA: 0x003451CC File Offset: 0x003433CC
	protected void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.MotorArrowBossHpChange, new Action<FKSC_HeadHpContext>(this.OnMotorArrowBossHpChange));
		EventSystem.Instance.Remove(EEventName.MotorArrowBossCreate, new Action<string>(this.OnMotorArrowBossCreate));
		EventSystem.Instance.Remove(EEventName.LevelGamePlayPrepareCountDownEnd, new Action(this.OnCountDownEnd));
		EventSystem.Instance.Remove(EEventName.MotorArrowSave, new Action(this.OnSave));
	}

	// Token: 0x0600DF5F RID: 57183 RVA: 0x0034524C File Offset: 0x0034344C
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

	// Token: 0x0600DF60 RID: 57184 RVA: 0x003452B4 File Offset: 0x003434B4
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

	// Token: 0x0600DF61 RID: 57185 RVA: 0x00345372 File Offset: 0x00343572
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

	// Token: 0x0600DF62 RID: 57186 RVA: 0x00345388 File Offset: 0x00343588
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

	// Token: 0x0600DF63 RID: 57187 RVA: 0x00345414 File Offset: 0x00343614
	protected override void OnStart()
	{
	}

	// Token: 0x0600DF64 RID: 57188 RVA: 0x00345416 File Offset: 0x00343616
	private void OnButtonStopClicked()
	{
		UiManager.Instance.OpenView(EUiViewName.MotorFightPauseView, null, null);
	}

	// Token: 0x0600DF65 RID: 57189 RVA: 0x0034542C File Offset: 0x0034362C
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

	// Token: 0x040066BA RID: 26298
	protected MotorcycleArrowHpPlayerItem HpPlayerItem;

	// Token: 0x040066BB RID: 26299
	protected MotorcycleArrowBattleProgressItem BattleProgressItem;

	// Token: 0x040066BC RID: 26300
	protected MotorcycleArrowScore ScoreItem;

	// Token: 0x040066BD RID: 26301
	protected MotorcycleArrowBossHpItem BossHpItem;

	// Token: 0x040066BE RID: 26302
	protected SimpleBossStateItem BossHpItem2;

	// Token: 0x040066BF RID: 26303
	protected UUIItem SaveItem;

	// Token: 0x040066C0 RID: 26304
	private TimerHandle HideSaveTimer;

	// Token: 0x040066C1 RID: 26305
	protected UUIButtonComponent ButtonControlL;

	// Token: 0x040066C2 RID: 26306
	protected UUIButtonComponent ButtonControlR;

	// Token: 0x040066C3 RID: 26307
	protected UUIButtonComponent ButtonStop;

	// Token: 0x040066C4 RID: 26308
	private MotorcycleControlPanelBase MotorcycleControlPanel;

	// Token: 0x040066C5 RID: 26309
	private int ShowSaveDuration;

	// Token: 0x020082D3 RID: 33491
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402AAEE RID: 174830
		public const int BattleProgress = 0;

		// Token: 0x0402AAEF RID: 174831
		public const int BattleHpPlayer = 1;

		// Token: 0x0402AAF0 RID: 174832
		public const int Score = 2;

		// Token: 0x0402AAF1 RID: 174833
		public const int Save = 3;

		// Token: 0x0402AAF2 RID: 174834
		public const int Skill = 4;

		// Token: 0x0402AAF3 RID: 174835
		public const int ButtonControlL = 5;

		// Token: 0x0402AAF4 RID: 174836
		public const int ButtonControlR = 6;

		// Token: 0x0402AAF5 RID: 174837
		public const int BossHp = 7;

		// Token: 0x0402AAF6 RID: 174838
		public const int ButtonStop = 8;

		// Token: 0x0402AAF7 RID: 174839
		public const int ButtonControlRoot = 9;
	}
}
