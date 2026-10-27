using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.KuroSimpleCombat.PB;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001CEE RID: 7406
[NullableContext(1)]
[Nullable(0)]
public class PinballBattleMainBattlePanel : BattleChildViewPanel, IStaticVariableResetter
{
	// Token: 0x0600E044 RID: 57412 RVA: 0x00348A65 File Offset: 0x00346C65
	static PinballBattleMainBattlePanel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PinballBattleMainBattlePanel.CreateStaticDefaultValue), new Action(PinballBattleMainBattlePanel.ResetStaticDefaultValue));
	}

	// Token: 0x0600E045 RID: 57413 RVA: 0x00348A84 File Offset: 0x00346C84
	public static void CreateStaticDefaultValue()
	{
		PinballBattleMainBattlePanel.DashBarRange = new float[]
		{
			0f,
			0.75f
		};
		PinballBattleMainBattlePanel.ComboSeqNames = new string[]
		{
			"Combo_In",
			"Combo_Out",
			"Combo_Up"
		};
	}

	// Token: 0x0600E046 RID: 57414 RVA: 0x00348ABC File Offset: 0x00346CBC
	public static void ResetStaticDefaultValue()
	{
		PinballBattleMainBattlePanel.DashBarRange = null;
		PinballBattleMainBattlePanel.ComboSeqNames = null;
	}

	// Token: 0x0600E047 RID: 57415 RVA: 0x00348ACC File Offset: 0x00346CCC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 20;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIArtText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUILayoutBase));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIArtText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600E048 RID: 57416 RVA: 0x00348D94 File Offset: 0x00346F94
	protected override UniTask OnBeforeStartAsync()
	{
		PinballBattleMainBattlePanel.<OnBeforeStartAsync>d__25 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PinballBattleMainBattlePanel.<OnBeforeStartAsync>d__25>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E049 RID: 57417 RVA: 0x00348DD8 File Offset: 0x00346FD8
	protected override void OnStart()
	{
		this.InitCacheComponent();
		this.InitCountdown();
		this.InitCaption();
		this.InitStarLayout();
		this.InitLevelInfo();
		this.InitLevelSequencePlayer();
		this.BindButtonEvent();
		this.TryBindTeamEntity();
		PinballModel instance = PinballModel.Instance;
		if (instance == null)
		{
			return;
		}
		instance.SetBattleCenterRootItem(base.GetItem(17));
	}

	// Token: 0x0600E04A RID: 57418 RVA: 0x00348E2C File Offset: 0x0034702C
	protected override void OnBeforeDestroy()
	{
		this.UnBindDashAttrDelegate();
		PinballModel instance = PinballModel.Instance;
		if (instance != null)
		{
			instance.ClearBattleCenterRootItem();
		}
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer == null)
		{
			return;
		}
		seqPlayer.Clear();
	}

	// Token: 0x0600E04B RID: 57419 RVA: 0x00348E54 File Offset: 0x00347054
	protected override void OnShowBattleChildViewPanel(bool isFirst)
	{
		this.RefreshRoleSkillItemList();
		this.RefreshLevelInfo();
		this.RefreshDashButton();
		this.PlaySwitchIn();
	}

	// Token: 0x0600E04C RID: 57420 RVA: 0x00348E6E File Offset: 0x0034706E
	public override void OnTickBattleChildViewPanel(float delta)
	{
		this.TickCountdown(delta * Time.Instance.TimeDilation);
		this.RefreshSkillBtnState();
	}

	// Token: 0x0600E04D RID: 57421 RVA: 0x00348E88 File Offset: 0x00347088
	private void InitLevelSequencePlayer()
	{
		this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
		this.SeqPlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceFinished), false);
	}

	// Token: 0x0600E04E RID: 57422 RVA: 0x00348EB4 File Offset: 0x003470B4
	private void InitCacheComponent()
	{
		this.TimeText = base.GetText(8);
		this.ScoreText = base.GetArtText(9);
		this.ComboNum = base.GetArtText(15);
		this.ScoreProgressBar = base.GetTexture(11);
		this.ComboPanel = base.GetItem(14);
		this.SkillBtn = base.GetButton(6);
	}

	// Token: 0x0600E04F RID: 57423 RVA: 0x00348F14 File Offset: 0x00347114
	protected override void AddEvents()
	{
		EventSystem.Instance.Add<FKSC_HeadHpContext>(EEventName.OnPinballEntityHpChanged, new Action<FKSC_HeadHpContext>(this.OnEntityHpChange));
		EventSystem.Instance.Add<int>(EEventName.OnPinballScoreChanged, new Action<int>(this.OnScoreChange));
		EventSystem.Instance.Add<int>(EEventName.OnPinballComboChanged, new Action<int>(this.OnComboChange));
		EventSystem.Instance.Add<int>(EEventName.OnPinballEntityCreated, new Action<int>(this.OnEntityCreated));
		EventSystem.Instance.Add(EEventName.OnKscPlayerCreate, new Action(this.OnPlayerCreate));
		EventSystem.Instance.Add(EEventName.OnPinballBattleViewSwitchIn, new Action(this.OnPinballBattleViewSwitchIn));
		EventSystem.Instance.Add(EEventName.OnPinballFirstLaunch, new Action(this.OnFirstLaunch));
		EventSystem.Instance.Add<bool>(EEventName.OnPinballFeverChange, new Action<bool>(this.OnFeverChange));
	}

	// Token: 0x0600E050 RID: 57424 RVA: 0x00349004 File Offset: 0x00347204
	protected override void RemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnPinballEntityHpChanged, new Action<FKSC_HeadHpContext>(this.OnEntityHpChange));
		EventSystem.Instance.Remove<int>(EEventName.OnPinballScoreChanged, new Action<int>(this.OnScoreChange));
		EventSystem.Instance.Remove(EEventName.OnPinballComboChanged, new Action<int>(this.OnComboChange));
		EventSystem.Instance.Remove(EEventName.OnPinballEntityCreated, new Action<int>(this.OnEntityCreated));
		EventSystem.Instance.Remove(EEventName.OnKscPlayerCreate, new Action(this.OnPlayerCreate));
		EventSystem.Instance.Remove(EEventName.OnPinballBattleViewSwitchIn, new Action(this.OnPinballBattleViewSwitchIn));
		EventSystem.Instance.Remove(EEventName.OnPinballFirstLaunch, new Action(this.OnFirstLaunch));
		EventSystem.Instance.Remove(EEventName.OnPinballFeverChange, new Action<bool>(this.OnFeverChange));
	}

	// Token: 0x0600E051 RID: 57425 RVA: 0x003490F4 File Offset: 0x003472F4
	private void BindButtonEvent()
	{
		UUIButtonComponent button = base.GetButton(5);
		if (button != null)
		{
			button.OnPointDownCallBack.Bind(new Action(this.OnBtnShootClick));
		}
		UUIButtonComponent button2 = base.GetButton(6);
		if (button2 != null)
		{
			button2.OnPointDownCallBack.Bind(new Action(this.OnBtnDashClick));
		}
		UUIButtonComponent button3 = base.GetButton(18);
		if (button3 != null)
		{
			button3.OnPointDownCallBack.Bind(new Action(this.OnCenterBtnShootClick));
		}
		UUIButtonComponent button4 = base.GetButton(1);
		if (button4 == null)
		{
			return;
		}
		button4.OnPointDownCallBack.Bind(new Action(this.OnBtnResetClick));
	}

	// Token: 0x0600E052 RID: 57426 RVA: 0x0034918D File Offset: 0x0034738D
	private void OnSequenceFinished(string sequenceName)
	{
		if (sequenceName == "Combo_Out")
		{
			UUIItem comboPanel = this.ComboPanel;
			if (comboPanel == null)
			{
				return;
			}
			comboPanel.SetUIActive(false);
		}
	}

	// Token: 0x0600E053 RID: 57427 RVA: 0x003491B0 File Offset: 0x003473B0
	private void OnFeverChange(bool isIn)
	{
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer == null)
		{
			return;
		}
		seqPlayer.PlayOrReplaySequenceByName(isIn ? "Fever_In" : "Fever_Out", false, null);
	}

	// Token: 0x0600E054 RID: 57428 RVA: 0x003491E6 File Offset: 0x003473E6
	private void OnFirstLaunch()
	{
		this.StartCountdown();
	}

	// Token: 0x0600E055 RID: 57429 RVA: 0x003491EE File Offset: 0x003473EE
	private void OnPlayerCreate()
	{
		this.RefreshRoleSkillItemList();
	}

	// Token: 0x0600E056 RID: 57430 RVA: 0x003491F6 File Offset: 0x003473F6
	private void OnEntityCreated(int entityId)
	{
		if (entityId == 10001)
		{
			this.TryBindTeamEntity();
		}
	}

	// Token: 0x0600E057 RID: 57431 RVA: 0x00349206 File Offset: 0x00347406
	private void OnClickRoleSkill(int roleId)
	{
		PinballController instance = PinballController.Instance;
		if (instance == null)
		{
			return;
		}
		instance.ShowRoleSkillTips(roleId, new Action(this.OnRoleSkillReleaseTipsClose));
	}

	// Token: 0x0600E058 RID: 57432 RVA: 0x00349224 File Offset: 0x00347424
	private void OnRoleSkillReleaseTipsClose()
	{
		foreach (PinballBattleRoleSkillItem pinballBattleRoleSkillItem in this.RoleSkillItemList)
		{
			pinballBattleRoleSkillItem.StartClickCooldown();
		}
	}

	// Token: 0x0600E059 RID: 57433 RVA: 0x00349274 File Offset: 0x00347474
	private void OnPinballBattleViewSwitchIn()
	{
		this.PlaySwitchIn();
	}

	// Token: 0x0600E05A RID: 57434 RVA: 0x0034927C File Offset: 0x0034747C
	private void PlaySwitchIn()
	{
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer != null)
		{
			seqPlayer.StopSequenceByKey("Switch_Out", false, true);
		}
		LevelSequencePlayer seqPlayer2 = this.SeqPlayer;
		if (seqPlayer2 == null)
		{
			return;
		}
		seqPlayer2.PlayOrReplaySequenceByName("Switch_In", false, null);
	}

	// Token: 0x0600E05B RID: 57435 RVA: 0x003492C0 File Offset: 0x003474C0
	private void OnEntityHpChange(FKSC_HeadHpContext hpContext)
	{
		if (hpContext.HeadUiType == EKSC_HeadUiType.TopBoss)
		{
			PinballBattleBossHpBar bossHpBar = this.BossHpBar;
			if (bossHpBar == null)
			{
				return;
			}
			bossHpBar.Refresh(hpContext);
		}
	}

	// Token: 0x0600E05C RID: 57436 RVA: 0x003492DC File Offset: 0x003474DC
	private void OnScoreChange(int score)
	{
		PinballBattleSubModel pinballBattleSubModel = KuroSimpleCombatController.Instance.CurSubModel as PinballBattleSubModel;
		UUIArtText scoreText = this.ScoreText;
		if (scoreText != null)
		{
			scoreText.SetText(score.ToString());
		}
		this.RefreshProgress(((pinballBattleSubModel != null) ? pinballBattleSubModel.LevelScoreTargetList : null) ?? new List<float>(), (float)score);
	}

	// Token: 0x0600E05D RID: 57437 RVA: 0x00349330 File Offset: 0x00347530
	private void PlayComboSequence(string name)
	{
		foreach (string text in PinballBattleMainBattlePanel.ComboSeqNames)
		{
			if (text != name)
			{
				LevelSequencePlayer seqPlayer = this.SeqPlayer;
				if (seqPlayer != null)
				{
					seqPlayer.StopSequenceByKey(text, false, true);
				}
			}
		}
		LevelSequencePlayer seqPlayer2 = this.SeqPlayer;
		if (seqPlayer2 == null)
		{
			return;
		}
		seqPlayer2.PlayOrReplaySequenceByName(name, false, null);
	}

	// Token: 0x0600E05E RID: 57438 RVA: 0x00349390 File Offset: 0x00347590
	private void OnComboChange(int newValue)
	{
		if (this.LastCombo == 0 && newValue > 0)
		{
			this.PlayComboSequence("Combo_In");
		}
		else if (this.LastCombo > 0 && newValue == 0)
		{
			this.PlayComboSequence("Combo_Out");
		}
		else
		{
			this.PlayComboSequence("Combo_Up");
		}
		this.LastCombo = newValue;
		if (newValue != 0)
		{
			UUIItem comboPanel = this.ComboPanel;
			if (comboPanel != null)
			{
				comboPanel.SetUIActive(true);
			}
			UUIArtText comboNum = this.ComboNum;
			if (comboNum == null)
			{
				return;
			}
			comboNum.SetText(newValue.ToString());
		}
	}

	// Token: 0x0600E05F RID: 57439 RVA: 0x00349410 File Offset: 0x00347610
	private void OnGameplayCdChanged(float remainTime)
	{
		int num = (int)Math.Floor((double)(remainTime / 1000f));
		int value = (int)Math.Floor((double)num % TimeUtil.Instance.Hour / (double)((float)TimeUtil.Instance.Minute));
		double num2 = (double)num % TimeUtil.Instance.Minute;
		string str = this.FormatTimeUnit(value);
		string str2 = this.FormatTimeUnit((int)num2);
		UUIText timeText = this.TimeText;
		if (timeText == null)
		{
			return;
		}
		timeText.SetText(str + ":" + str2, true);
	}

	// Token: 0x0600E060 RID: 57440 RVA: 0x00349488 File Offset: 0x00347688
	private string FormatTimeUnit(int value)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
		defaultInterpolatedStringHandler.AppendFormatted((value < 10) ? "0" : "");
		defaultInterpolatedStringHandler.AppendFormatted<int>(value);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600E061 RID: 57441 RVA: 0x003494C8 File Offset: 0x003476C8
	private void InitCaption()
	{
		PopupCaptionItem caption = this.Caption;
		if (caption != null)
		{
			caption.SetCloseCallBack(delegate
			{
				PinballBattleSubModel pinballBattleSubModel = KuroSimpleCombatController.Instance.CurSubModel as PinballBattleSubModel;
				if (pinballBattleSubModel == null || pinballBattleSubModel.GameState != 1)
				{
					return;
				}
				UiManager.Instance.OpenView(EUiViewName.PinballBattlePauseView, new PinballBattlePauseViewParam
				{
					LevelId = pinballBattleSubModel.LevelId
				}, null);
			});
		}
		int curLevelConfigId = PinballModel.Instance.CurLevelConfigId;
		PinballConfig instance = PinballConfig.Instance;
		PinballLevelConfig? pinballLevelConfig = (instance != null) ? instance.GetPinballLevelConfigById(curLevelConfigId) : null;
		PopupCaptionItem caption2 = this.Caption;
		if (caption2 == null)
		{
			return;
		}
		caption2.SetTitleLocalText(((pinballLevelConfig != null) ? pinballLevelConfig.GetValueOrDefault().Name : null) ?? "");
	}

	// Token: 0x0600E062 RID: 57442 RVA: 0x00349560 File Offset: 0x00347760
	private void InitLevelInfo()
	{
		int curLevelId = PinballModel.Instance.CurLevelId;
		PinballConfig instance = PinballConfig.Instance;
		PinballLevelConfig? pinballLevelConfig = (instance != null) ? instance.GetPinballLevelConfigById(curLevelId) : null;
		this.IsCowLevel = (pinballLevelConfig != null && pinballLevelConfig.GetValueOrDefault().Type == 2);
		UUIItem item = base.GetItem(10);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(this.IsCowLevel);
	}

	// Token: 0x0600E063 RID: 57443 RVA: 0x003495D0 File Offset: 0x003477D0
	private void RefreshProgress(List<float> scoreTargetList, float curScore)
	{
		if (!this.IsCowLevel)
		{
			return;
		}
		int count = scoreTargetList.Count;
		if (count == 0)
		{
			UUITexture scoreProgressBar = this.ScoreProgressBar;
			if (scoreProgressBar == null)
			{
				return;
			}
			scoreProgressBar.SetFillAmount(0f);
			return;
		}
		else
		{
			float num = 0f;
			float num2 = 0f;
			for (int i = 0; i < count; i++)
			{
				float num3 = (i == 0) ? 0f : scoreTargetList[i - 1];
				float num4 = scoreTargetList[i];
				if (curScore >= num4)
				{
					num += 1f / (float)count;
				}
				else if (curScore > num3)
				{
					float num5 = 428f / (float)count - 50f;
					float num6 = (curScore - num3) / ((num4 - num3 != 0f) ? (num4 - num3) : 1f);
					num2 = num5 * num6 / 428f;
					break;
				}
			}
			UUITexture scoreProgressBar2 = this.ScoreProgressBar;
			if (scoreProgressBar2 != null)
			{
				scoreProgressBar2.SetFillAmount(num + num2);
			}
			List<bool> list = new List<bool>();
			for (int j = 0; j < count; j++)
			{
				list.Add(curScore >= scoreTargetList[j]);
			}
			GenericLayout<PinballBattleStarItem, bool> starLayout = this.StarLayout;
			if (starLayout == null)
			{
				return;
			}
			starLayout.RefreshByData(list, null, false);
			return;
		}
	}

	// Token: 0x0600E064 RID: 57444 RVA: 0x003496E4 File Offset: 0x003478E4
	private void RefreshDashButton()
	{
		this.RefreshSkillBtnState();
		this.UpdateDashSkillBar();
	}

	// Token: 0x0600E065 RID: 57445 RVA: 0x003496F4 File Offset: 0x003478F4
	private void RefreshLevelInfo()
	{
		PinballBattleSubController pinballBattleSubController = KuroSimpleCombatController.Instance.CurSubController as PinballBattleSubController;
		this.OnGameplayCdChanged(this.LevelCountdownTimer);
		PinballBattleSubModel pinballBattleSubModel = (pinballBattleSubController != null) ? pinballBattleSubController.GetModel() : null;
		float curScore = (pinballBattleSubModel != null) ? pinballBattleSubModel.Score : 0f;
		UUIArtText scoreText = this.ScoreText;
		if (scoreText != null)
		{
			scoreText.SetText(curScore.ToString());
		}
		this.RefreshProgress(((pinballBattleSubModel != null) ? pinballBattleSubModel.LevelScoreTargetList : null) ?? new List<float>(), curScore);
	}

	// Token: 0x0600E066 RID: 57446 RVA: 0x0034976E File Offset: 0x0034796E
	private void InitStarLayout()
	{
		this.StarLayout = new GenericLayout<PinballBattleStarItem, bool>(base.GetLayoutBase(12), new Func<PinballBattleStarItem>(this.CreateStarItem), base.GetItem(13).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x0600E067 RID: 57447 RVA: 0x003497A3 File Offset: 0x003479A3
	private PinballBattleStarItem CreateStarItem()
	{
		return new PinballBattleStarItem();
	}

	// Token: 0x0600E068 RID: 57448 RVA: 0x003497AC File Offset: 0x003479AC
	public void RefreshRoleSkillItemList()
	{
		PinballBattleSubModel pinballBattleSubModel = KuroSimpleCombatController.Instance.CurSubModel as PinballBattleSubModel;
		List<PinballFormationRolePb> list = (pinballBattleSubModel != null) ? pinballBattleSubModel.PreloadFormationData : null;
		List<int> list2 = new List<int>();
		if (list != null)
		{
			foreach (PinballFormationRolePb pinballFormationRolePb in list)
			{
				list2.Add(pinballFormationRolePb.RoleId);
			}
		}
		for (int i = 0; i < this.RoleSkillItemList.Count; i++)
		{
			PinballBattleRoleSkillItem pinballBattleRoleSkillItem = this.RoleSkillItemList[i];
			if (i < list2.Count)
			{
				pinballBattleRoleSkillItem.Refresh(list2[i]);
			}
			else
			{
				pinballBattleRoleSkillItem.Refresh(-1);
			}
		}
	}

	// Token: 0x0600E069 RID: 57449 RVA: 0x00349870 File Offset: 0x00347A70
	private void OnCenterBtnShootClick()
	{
		if (Info.Instance.IsInKeyBoard() && (InputSettings.Instance.IsInputKeyDown("RightMouseButton") || !InputSettings.Instance.IsInputKeyDown("LeftMouseButton")))
		{
			return;
		}
		this.OnBtnShootClick();
	}

	// Token: 0x0600E06A RID: 57450 RVA: 0x003498A8 File Offset: 0x00347AA8
	private void OnBtnShootClick()
	{
		PinballBattleSubController pinballBattleSubController = KuroSimpleCombatController.Instance.CurSubController as PinballBattleSubController;
		if (pinballBattleSubController == null)
		{
			return;
		}
		pinballBattleSubController.OnInputTriggerBar();
	}

	// Token: 0x0600E06B RID: 57451 RVA: 0x003498CF File Offset: 0x00347ACF
	private bool CanUseDashSkill(PinballBattleSubController subController)
	{
		if (this.CanEnableDashSkill(subController) && Time.Instance.TimeDilation != 0f)
		{
			PinballBattleLaunchPhaseController launchPhaseController = subController.LaunchPhaseController;
			return launchPhaseController == null || !launchPhaseController.IsActive();
		}
		return false;
	}

	// Token: 0x0600E06C RID: 57452 RVA: 0x00349904 File Offset: 0x00347B04
	private bool CanEnableDashSkill(PinballBattleSubController subController)
	{
		if (this.OwnerAttrSet == null || subController == null)
		{
			return false;
		}
		float? dashNeedCost = subController.GetDashNeedCost();
		return dashNeedCost != null && (float)this.OwnerAttrSet.Attrs_.GetValueOrNull(<PinballBattleMainBattlePanel>F13954715AA9E400802E82B74BFA19540AB238E6555C9E1ECFC5E2AF3E01CA6FF__MainBattleConst.DashAttrType).GetValueOrDefault() >= dashNeedCost.Value && !subController.IsInDashCd();
	}

	// Token: 0x0600E06D RID: 57453 RVA: 0x00349964 File Offset: 0x00347B64
	private void OnBtnDashClick()
	{
		PinballBattleSubController pinballBattleSubController = KuroSimpleCombatController.Instance.CurSubController as PinballBattleSubController;
		if (!this.CanUseDashSkill(pinballBattleSubController))
		{
			return;
		}
		pinballBattleSubController.OnInputUseTeamSkill(1);
	}

	// Token: 0x0600E06E RID: 57454 RVA: 0x00349994 File Offset: 0x00347B94
	private void OnBtnResetClick()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PinballBattleResetLaunchConfirm);
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			PinballBattleSubController pinballBattleSubController = KuroSimpleCombatController.Instance.CurSubController as PinballBattleSubController;
			if (pinballBattleSubController == null)
			{
				return;
			}
			pinballBattleSubController.ReadyLaunch();
		};
		PinballController.Instance.OpenPinballSmallConfirmBoxView(confirmBoxDataNew);
	}

	// Token: 0x0600E06F RID: 57455 RVA: 0x003499E4 File Offset: 0x00347BE4
	private void TryBindTeamEntity()
	{
		PinballBattleSubController pinballBattleSubController = KuroSimpleCombatController.Instance.CurSubController as PinballBattleSubController;
		AKSC_Shape2D_Entity_TeamPlayer aksc_Shape2D_Entity_TeamPlayer = (pinballBattleSubController != null) ? pinballBattleSubController.KscTeamPlayer : null;
		if (aksc_Shape2D_Entity_TeamPlayer != null)
		{
			this.BindTeamEntity(aksc_Shape2D_Entity_TeamPlayer);
		}
	}

	// Token: 0x0600E070 RID: 57456 RVA: 0x00349A18 File Offset: 0x00347C18
	private void BindTeamEntity(AKSC_Entity entity)
	{
		UKSC_SkillComp skillComp_ = entity.SkillComp_;
		UKSC_AttrSet uksc_AttrSet = (skillComp_ != null) ? skillComp_.AttrSet_ : null;
		if (uksc_AttrSet == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PinballBattle;
			ELogAuthor author = ELogAuthor.LJ;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
			defaultInterpolatedStringHandler.AppendLiteral("实体没有属性组件！EntityId：");
			defaultInterpolatedStringHandler.AppendFormatted<int>(entity.EntityId_);
			instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.BindDashAttrDelegate(uksc_AttrSet);
		this.UpdateDashSkillBar();
	}

	// Token: 0x0600E071 RID: 57457 RVA: 0x00349A90 File Offset: 0x00347C90
	private void UpdateDashSkillBar()
	{
		UKSC_AttrSet ownerAttrSet = this.OwnerAttrSet;
		int? num;
		if (ownerAttrSet == null)
		{
			num = null;
		}
		else
		{
			TMap<EKSC_AttrType, int> attrs_ = ownerAttrSet.Attrs_;
			num = ((attrs_ != null) ? attrs_.GetValueOrNull(<PinballBattleMainBattlePanel>F13954715AA9E400802E82B74BFA19540AB238E6555C9E1ECFC5E2AF3E01CA6FF__MainBattleConst.DashAttrType) : null);
		}
		int? num2 = num;
		int valueOrDefault = num2.GetValueOrDefault();
		UKSC_AttrSet ownerAttrSet2 = this.OwnerAttrSet;
		int? num3;
		if (ownerAttrSet2 == null)
		{
			num3 = null;
		}
		else
		{
			TMap<EKSC_AttrType, int> attrs_2 = ownerAttrSet2.Attrs_;
			num3 = ((attrs_2 != null) ? attrs_2.GetValueOrNull(<PinballBattleMainBattlePanel>F13954715AA9E400802E82B74BFA19540AB238E6555C9E1ECFC5E2AF3E01CA6FF__MainBattleConst.DashMaxAttrType) : null);
		}
		num2 = num3;
		int valueOrDefault2 = num2.GetValueOrDefault(1);
		UUISprite sprite = base.GetSprite(7);
		if (sprite == null)
		{
			return;
		}
		sprite.SetFillAmount(MathUtils.Instance.Lerp(PinballBattleMainBattlePanel.DashBarRange[0], PinballBattleMainBattlePanel.DashBarRange[1], (float)valueOrDefault / (float)valueOrDefault2));
	}

	// Token: 0x0600E072 RID: 57458 RVA: 0x00349B44 File Offset: 0x00347D44
	public void BindDashAttrDelegate(UKSC_AttrSet attrSet)
	{
		this.UnBindDashAttrDelegate();
		this.DelegateDashChange = DelegateUtils.ToManualReleaseDelegate<FOnKSCAttrChange>(new Action<EKSC_AttrType, int>(this.OnDashChange));
		attrSet.AssignAttrListen(<PinballBattleMainBattlePanel>F13954715AA9E400802E82B74BFA19540AB238E6555C9E1ECFC5E2AF3E01CA6FF__MainBattleConst.DashAttrType, this.DelegateDashChange);
		attrSet.AssignAttrListen(<PinballBattleMainBattlePanel>F13954715AA9E400802E82B74BFA19540AB238E6555C9E1ECFC5E2AF3E01CA6FF__MainBattleConst.DashMaxAttrType, this.DelegateDashChange);
		this.OwnerAttrSet = attrSet;
	}

	// Token: 0x0600E073 RID: 57459 RVA: 0x00349B98 File Offset: 0x00347D98
	public void UnBindDashAttrDelegate()
	{
		if (this.OwnerAttrSet != null)
		{
			this.OwnerAttrSet.RemoveAttrListen(<PinballBattleMainBattlePanel>F13954715AA9E400802E82B74BFA19540AB238E6555C9E1ECFC5E2AF3E01CA6FF__MainBattleConst.DashAttrType, this.DelegateDashChange);
			this.OwnerAttrSet.RemoveAttrListen(<PinballBattleMainBattlePanel>F13954715AA9E400802E82B74BFA19540AB238E6555C9E1ECFC5E2AF3E01CA6FF__MainBattleConst.DashMaxAttrType, this.DelegateDashChange);
			this.OwnerAttrSet = null;
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<EKSC_AttrType, int>(this.OnDashChange));
			this.DelegateDashChange = null;
		}
	}

	// Token: 0x0600E074 RID: 57460 RVA: 0x00349BF8 File Offset: 0x00347DF8
	private void OnDashChange(EKSC_AttrType attrType, int value)
	{
		this.UpdateDashSkillBar();
	}

	// Token: 0x0600E075 RID: 57461 RVA: 0x00349C00 File Offset: 0x00347E00
	private void RefreshSkillBtnState()
	{
		PinballBattleSubController pinballBattleSubController = KuroSimpleCombatController.Instance.CurSubController as PinballBattleSubController;
		bool flag = pinballBattleSubController != null && this.CanEnableDashSkill(pinballBattleSubController);
		if (flag != this.LastCanUseDash)
		{
			this.LastCanUseDash = flag;
			UUIButtonComponent skillBtn = this.SkillBtn;
			if (skillBtn == null)
			{
				return;
			}
			skillBtn.SetSelfInteractive(flag);
		}
	}

	// Token: 0x0600E076 RID: 57462 RVA: 0x00349C4C File Offset: 0x00347E4C
	private void InitCountdown()
	{
		int curLevelId = PinballModel.Instance.CurLevelId;
		PinballLevelConfig? pinballLevelConfigById = PinballConfig.Instance.GetPinballLevelConfigById(curLevelId);
		if (pinballLevelConfigById == null)
		{
			return;
		}
		this.LevelCountdownTimer = (float)(pinballLevelConfigById.Value.LevelTime * 1000);
	}

	// Token: 0x0600E077 RID: 57463 RVA: 0x00349C96 File Offset: 0x00347E96
	private void StartCountdown()
	{
		this.IsCountdownStart = true;
		this.OnGameplayCdChanged(this.LevelCountdownTimer);
	}

	// Token: 0x0600E078 RID: 57464 RVA: 0x00349CAC File Offset: 0x00347EAC
	private void TickCountdown(float delta)
	{
		if (delta == 0f || !this.IsCountdownStart)
		{
			return;
		}
		this.LevelCountdownTimer -= delta;
		this.TickTimer += delta;
		if (this.TickTimer < 1000f)
		{
			return;
		}
		this.TickTimer = 0f;
		if (this.LevelCountdownTimer <= 0f)
		{
			this.IsCountdownStart = false;
			this.OnGameplayCdChanged(0f);
			return;
		}
		this.OnGameplayCdChanged(this.LevelCountdownTimer);
	}

	// Token: 0x0600E079 RID: 57465 RVA: 0x00349D2C File Offset: 0x00347F2C
	public void PlaySequence(string name)
	{
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer == null)
		{
			return;
		}
		seqPlayer.PlayOrReplaySequenceByName(name, false, null);
	}

	// Token: 0x0400676A RID: 26474
	[Nullable(2)]
	private static float[] DashBarRange;

	// Token: 0x0400676B RID: 26475
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static string[] ComboSeqNames;

	// Token: 0x0400676C RID: 26476
	[Nullable(2)]
	private PopupCaptionItem Caption;

	// Token: 0x0400676D RID: 26477
	private readonly List<PinballBattleRoleSkillItem> RoleSkillItemList = new List<PinballBattleRoleSkillItem>();

	// Token: 0x0400676E RID: 26478
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<PinballBattleStarItem, bool> StarLayout;

	// Token: 0x0400676F RID: 26479
	[Nullable(2)]
	private PinballBattleBossHpBar BossHpBar;

	// Token: 0x04006770 RID: 26480
	[Nullable(2)]
	private UUIText TimeText;

	// Token: 0x04006771 RID: 26481
	[Nullable(2)]
	private UUIArtText ScoreText;

	// Token: 0x04006772 RID: 26482
	[Nullable(2)]
	private UUIArtText ComboNum;

	// Token: 0x04006773 RID: 26483
	[Nullable(2)]
	private UUIItem ComboPanel;

	// Token: 0x04006774 RID: 26484
	[Nullable(2)]
	private UUITexture ScoreProgressBar;

	// Token: 0x04006775 RID: 26485
	[Nullable(2)]
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x04006776 RID: 26486
	[Nullable(2)]
	private UKSC_AttrSet OwnerAttrSet;

	// Token: 0x04006777 RID: 26487
	[Nullable(2)]
	private FOnKSCAttrChange DelegateDashChange;

	// Token: 0x04006778 RID: 26488
	private bool LastCanUseDash = true;

	// Token: 0x04006779 RID: 26489
	private bool IsCowLevel;

	// Token: 0x0400677A RID: 26490
	private int LastCombo;

	// Token: 0x0400677B RID: 26491
	[Nullable(2)]
	private UUIButtonComponent SkillBtn;

	// Token: 0x0400677C RID: 26492
	private float LevelCountdownTimer;

	// Token: 0x0400677D RID: 26493
	private bool IsCountdownStart;

	// Token: 0x0400677E RID: 26494
	private float TickTimer;
}
