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

// Token: 0x020011B0 RID: 4528
[NullableContext(1)]
[Nullable(0)]
public class PinballBattleMainBattlePanel : BattleChildViewPanel, IStaticVariableResetter
{
	// Token: 0x0600B461 RID: 46177 RVA: 0x0035448D File Offset: 0x0035268D
	static PinballBattleMainBattlePanel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PinballBattleMainBattlePanel.CreateStaticDefaultValue), new Action(PinballBattleMainBattlePanel.ResetStaticDefaultValue));
	}

	// Token: 0x0600B462 RID: 46178 RVA: 0x003544AC File Offset: 0x003526AC
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

	// Token: 0x0600B463 RID: 46179 RVA: 0x003544E4 File Offset: 0x003526E4
	public static void ResetStaticDefaultValue()
	{
		PinballBattleMainBattlePanel.DashBarRange = null;
		PinballBattleMainBattlePanel.ComboSeqNames = null;
	}

	// Token: 0x0600B464 RID: 46180 RVA: 0x003544F4 File Offset: 0x003526F4
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

	// Token: 0x0600B465 RID: 46181 RVA: 0x003547BC File Offset: 0x003529BC
	protected override UniTask OnBeforeStartAsync()
	{
		PinballBattleMainBattlePanel.<OnBeforeStartAsync>d__25 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PinballBattleMainBattlePanel.<OnBeforeStartAsync>d__25>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B466 RID: 46182 RVA: 0x00354800 File Offset: 0x00352A00
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

	// Token: 0x0600B467 RID: 46183 RVA: 0x00354854 File Offset: 0x00352A54
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

	// Token: 0x0600B468 RID: 46184 RVA: 0x0035487C File Offset: 0x00352A7C
	protected override void OnShowBattleChildViewPanel(bool isFirst)
	{
		this.RefreshRoleSkillItemList();
		this.RefreshLevelInfo();
		this.RefreshDashButton();
		this.PlaySwitchIn();
	}

	// Token: 0x0600B469 RID: 46185 RVA: 0x00354896 File Offset: 0x00352A96
	public override void OnTickBattleChildViewPanel(float delta)
	{
		this.TickCountdown(delta * Time.Instance.TimeDilation);
		this.RefreshSkillBtnState();
	}

	// Token: 0x0600B46A RID: 46186 RVA: 0x003548B0 File Offset: 0x00352AB0
	private void InitLevelSequencePlayer()
	{
		this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
		this.SeqPlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceFinished), false);
	}

	// Token: 0x0600B46B RID: 46187 RVA: 0x003548DC File Offset: 0x00352ADC
	private void InitCacheComponent()
	{
		this.TimeText = base.GetText(8);
		this.ScoreText = base.GetArtText(9);
		this.ComboNum = base.GetArtText(15);
		this.ScoreProgressBar = base.GetTexture(11);
		this.ComboPanel = base.GetItem(14);
		this.SkillBtn = base.GetButton(6);
	}

	// Token: 0x0600B46C RID: 46188 RVA: 0x0035493C File Offset: 0x00352B3C
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

	// Token: 0x0600B46D RID: 46189 RVA: 0x00354A2C File Offset: 0x00352C2C
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

	// Token: 0x0600B46E RID: 46190 RVA: 0x00354B1C File Offset: 0x00352D1C
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

	// Token: 0x0600B46F RID: 46191 RVA: 0x00354BB5 File Offset: 0x00352DB5
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

	// Token: 0x0600B470 RID: 46192 RVA: 0x00354BD8 File Offset: 0x00352DD8
	private void OnFeverChange(bool isIn)
	{
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer == null)
		{
			return;
		}
		seqPlayer.PlayOrReplaySequenceByName(isIn ? "Fever_In" : "Fever_Out", false, null);
	}

	// Token: 0x0600B471 RID: 46193 RVA: 0x00354C0E File Offset: 0x00352E0E
	private void OnFirstLaunch()
	{
		this.StartCountdown();
	}

	// Token: 0x0600B472 RID: 46194 RVA: 0x00354C16 File Offset: 0x00352E16
	private void OnPlayerCreate()
	{
		this.RefreshRoleSkillItemList();
	}

	// Token: 0x0600B473 RID: 46195 RVA: 0x00354C1E File Offset: 0x00352E1E
	private void OnEntityCreated(int entityId)
	{
		if (entityId == 10001)
		{
			this.TryBindTeamEntity();
		}
	}

	// Token: 0x0600B474 RID: 46196 RVA: 0x00354C2E File Offset: 0x00352E2E
	private void OnClickRoleSkill(int roleId)
	{
		PinballController instance = PinballController.Instance;
		if (instance == null)
		{
			return;
		}
		instance.ShowRoleSkillTips(roleId, new Action(this.OnRoleSkillReleaseTipsClose));
	}

	// Token: 0x0600B475 RID: 46197 RVA: 0x00354C4C File Offset: 0x00352E4C
	private void OnRoleSkillReleaseTipsClose()
	{
		foreach (PinballBattleRoleSkillItem pinballBattleRoleSkillItem in this.RoleSkillItemList)
		{
			pinballBattleRoleSkillItem.StartClickCooldown();
		}
	}

	// Token: 0x0600B476 RID: 46198 RVA: 0x00354C9C File Offset: 0x00352E9C
	private void OnPinballBattleViewSwitchIn()
	{
		this.PlaySwitchIn();
	}

	// Token: 0x0600B477 RID: 46199 RVA: 0x00354CA4 File Offset: 0x00352EA4
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

	// Token: 0x0600B478 RID: 46200 RVA: 0x00354CE8 File Offset: 0x00352EE8
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

	// Token: 0x0600B479 RID: 46201 RVA: 0x00354D04 File Offset: 0x00352F04
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

	// Token: 0x0600B47A RID: 46202 RVA: 0x00354D58 File Offset: 0x00352F58
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

	// Token: 0x0600B47B RID: 46203 RVA: 0x00354DB8 File Offset: 0x00352FB8
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

	// Token: 0x0600B47C RID: 46204 RVA: 0x00354E38 File Offset: 0x00353038
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

	// Token: 0x0600B47D RID: 46205 RVA: 0x00354EB0 File Offset: 0x003530B0
	private string FormatTimeUnit(int value)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
		defaultInterpolatedStringHandler.AppendFormatted((value < 10) ? "0" : "");
		defaultInterpolatedStringHandler.AppendFormatted<int>(value);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600B47E RID: 46206 RVA: 0x00354EF0 File Offset: 0x003530F0
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

	// Token: 0x0600B47F RID: 46207 RVA: 0x00354F88 File Offset: 0x00353188
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

	// Token: 0x0600B480 RID: 46208 RVA: 0x00354FF8 File Offset: 0x003531F8
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

	// Token: 0x0600B481 RID: 46209 RVA: 0x0035510C File Offset: 0x0035330C
	private void RefreshDashButton()
	{
		this.RefreshSkillBtnState();
		this.UpdateDashSkillBar();
	}

	// Token: 0x0600B482 RID: 46210 RVA: 0x0035511C File Offset: 0x0035331C
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

	// Token: 0x0600B483 RID: 46211 RVA: 0x00355196 File Offset: 0x00353396
	private void InitStarLayout()
	{
		this.StarLayout = new GenericLayout<PinballBattleStarItem, bool>(base.GetLayoutBase(12), new Func<PinballBattleStarItem>(this.CreateStarItem), base.GetItem(13).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x0600B484 RID: 46212 RVA: 0x003551CB File Offset: 0x003533CB
	private PinballBattleStarItem CreateStarItem()
	{
		return new PinballBattleStarItem();
	}

	// Token: 0x0600B485 RID: 46213 RVA: 0x003551D4 File Offset: 0x003533D4
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

	// Token: 0x0600B486 RID: 46214 RVA: 0x00355298 File Offset: 0x00353498
	private void OnCenterBtnShootClick()
	{
		if (Info.Instance.IsInKeyBoard() && (InputSettings.Instance.IsInputKeyDown("RightMouseButton") || !InputSettings.Instance.IsInputKeyDown("LeftMouseButton")))
		{
			return;
		}
		this.OnBtnShootClick();
	}

	// Token: 0x0600B487 RID: 46215 RVA: 0x003552D0 File Offset: 0x003534D0
	private void OnBtnShootClick()
	{
		PinballBattleSubController pinballBattleSubController = KuroSimpleCombatController.Instance.CurSubController as PinballBattleSubController;
		if (pinballBattleSubController == null)
		{
			return;
		}
		pinballBattleSubController.OnInputTriggerBar();
	}

	// Token: 0x0600B488 RID: 46216 RVA: 0x003552F7 File Offset: 0x003534F7
	private bool CanUseDashSkill(PinballBattleSubController subController)
	{
		if (this.CanEnableDashSkill(subController) && Time.Instance.TimeDilation != 0f)
		{
			PinballBattleLaunchPhaseController launchPhaseController = subController.LaunchPhaseController;
			return launchPhaseController == null || !launchPhaseController.IsActive();
		}
		return false;
	}

	// Token: 0x0600B489 RID: 46217 RVA: 0x0035532C File Offset: 0x0035352C
	private bool CanEnableDashSkill(PinballBattleSubController subController)
	{
		if (this.OwnerAttrSet == null || subController == null)
		{
			return false;
		}
		float? dashNeedCost = subController.GetDashNeedCost();
		return dashNeedCost != null && (float)this.OwnerAttrSet.Attrs_.GetValueOrNull(<PinballBattleMainBattlePanel>F13954715AA9E400802E82B74BFA19540AB238E6555C9E1ECFC5E2AF3E01CA6FF__MainBattleConst.DashAttrType).GetValueOrDefault() >= dashNeedCost.Value && !subController.IsInDashCd();
	}

	// Token: 0x0600B48A RID: 46218 RVA: 0x0035538C File Offset: 0x0035358C
	private void OnBtnDashClick()
	{
		PinballBattleSubController pinballBattleSubController = KuroSimpleCombatController.Instance.CurSubController as PinballBattleSubController;
		if (!this.CanUseDashSkill(pinballBattleSubController))
		{
			return;
		}
		pinballBattleSubController.OnInputUseTeamSkill(1);
	}

	// Token: 0x0600B48B RID: 46219 RVA: 0x003553BC File Offset: 0x003535BC
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

	// Token: 0x0600B48C RID: 46220 RVA: 0x0035540C File Offset: 0x0035360C
	private void TryBindTeamEntity()
	{
		PinballBattleSubController pinballBattleSubController = KuroSimpleCombatController.Instance.CurSubController as PinballBattleSubController;
		AKSC_Shape2D_Entity_TeamPlayer aksc_Shape2D_Entity_TeamPlayer = (pinballBattleSubController != null) ? pinballBattleSubController.KscTeamPlayer : null;
		if (aksc_Shape2D_Entity_TeamPlayer != null)
		{
			this.BindTeamEntity(aksc_Shape2D_Entity_TeamPlayer);
		}
	}

	// Token: 0x0600B48D RID: 46221 RVA: 0x00355440 File Offset: 0x00353640
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

	// Token: 0x0600B48E RID: 46222 RVA: 0x003554B8 File Offset: 0x003536B8
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

	// Token: 0x0600B48F RID: 46223 RVA: 0x0035556C File Offset: 0x0035376C
	public void BindDashAttrDelegate(UKSC_AttrSet attrSet)
	{
		this.UnBindDashAttrDelegate();
		this.DelegateDashChange = DelegateUtils.ToManualReleaseDelegate<FOnKSCAttrChange>(new Action<EKSC_AttrType, int>(this.OnDashChange));
		attrSet.AssignAttrListen(<PinballBattleMainBattlePanel>F13954715AA9E400802E82B74BFA19540AB238E6555C9E1ECFC5E2AF3E01CA6FF__MainBattleConst.DashAttrType, this.DelegateDashChange);
		attrSet.AssignAttrListen(<PinballBattleMainBattlePanel>F13954715AA9E400802E82B74BFA19540AB238E6555C9E1ECFC5E2AF3E01CA6FF__MainBattleConst.DashMaxAttrType, this.DelegateDashChange);
		this.OwnerAttrSet = attrSet;
	}

	// Token: 0x0600B490 RID: 46224 RVA: 0x003555C0 File Offset: 0x003537C0
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

	// Token: 0x0600B491 RID: 46225 RVA: 0x00355620 File Offset: 0x00353820
	private void OnDashChange(EKSC_AttrType attrType, int value)
	{
		this.UpdateDashSkillBar();
	}

	// Token: 0x0600B492 RID: 46226 RVA: 0x00355628 File Offset: 0x00353828
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

	// Token: 0x0600B493 RID: 46227 RVA: 0x00355674 File Offset: 0x00353874
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

	// Token: 0x0600B494 RID: 46228 RVA: 0x003556BE File Offset: 0x003538BE
	private void StartCountdown()
	{
		this.IsCountdownStart = true;
		this.OnGameplayCdChanged(this.LevelCountdownTimer);
	}

	// Token: 0x0600B495 RID: 46229 RVA: 0x003556D4 File Offset: 0x003538D4
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

	// Token: 0x0600B496 RID: 46230 RVA: 0x00355754 File Offset: 0x00353954
	public void PlaySequence(string name)
	{
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer == null)
		{
			return;
		}
		seqPlayer.PlayOrReplaySequenceByName(name, false, null);
	}

	// Token: 0x04006849 RID: 26697
	[Nullable(2)]
	private static float[] DashBarRange;

	// Token: 0x0400684A RID: 26698
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static string[] ComboSeqNames;

	// Token: 0x0400684B RID: 26699
	[Nullable(2)]
	private PopupCaptionItem Caption;

	// Token: 0x0400684C RID: 26700
	private readonly List<PinballBattleRoleSkillItem> RoleSkillItemList = new List<PinballBattleRoleSkillItem>();

	// Token: 0x0400684D RID: 26701
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<PinballBattleStarItem, bool> StarLayout;

	// Token: 0x0400684E RID: 26702
	[Nullable(2)]
	private PinballBattleBossHpBar BossHpBar;

	// Token: 0x0400684F RID: 26703
	[Nullable(2)]
	private UUIText TimeText;

	// Token: 0x04006850 RID: 26704
	[Nullable(2)]
	private UUIArtText ScoreText;

	// Token: 0x04006851 RID: 26705
	[Nullable(2)]
	private UUIArtText ComboNum;

	// Token: 0x04006852 RID: 26706
	[Nullable(2)]
	private UUIItem ComboPanel;

	// Token: 0x04006853 RID: 26707
	[Nullable(2)]
	private UUITexture ScoreProgressBar;

	// Token: 0x04006854 RID: 26708
	[Nullable(2)]
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x04006855 RID: 26709
	[Nullable(2)]
	private UKSC_AttrSet OwnerAttrSet;

	// Token: 0x04006856 RID: 26710
	[Nullable(2)]
	private FOnKSCAttrChange DelegateDashChange;

	// Token: 0x04006857 RID: 26711
	private bool LastCanUseDash = true;

	// Token: 0x04006858 RID: 26712
	private bool IsCowLevel;

	// Token: 0x04006859 RID: 26713
	private int LastCombo;

	// Token: 0x0400685A RID: 26714
	[Nullable(2)]
	private UUIButtonComponent SkillBtn;

	// Token: 0x0400685B RID: 26715
	private float LevelCountdownTimer;

	// Token: 0x0400685C RID: 26716
	private bool IsCountdownStart;

	// Token: 0x0400685D RID: 26717
	private float TickTimer;
}
