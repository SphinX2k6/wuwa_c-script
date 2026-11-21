using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.Kurotato;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200117E RID: 4478
[NullableContext(1)]
[Nullable(0)]
public class KurotatoMainPanel : UiPanelBase
{
	// Token: 0x1700122F RID: 4655
	// (get) Token: 0x0600B271 RID: 45681 RVA: 0x0034B930 File Offset: 0x00349B30
	private float CurHp
	{
		get
		{
			if (this.AttrMap == null)
			{
				return 0f;
			}
			int valueOrDefault = this.AttrMap.GetValueOrDefault(EKSC_AttrType.Life, 0);
			if (valueOrDefault > 0)
			{
				return (float)valueOrDefault;
			}
			return 0f;
		}
	}

	// Token: 0x17001230 RID: 4656
	// (get) Token: 0x0600B272 RID: 45682 RVA: 0x0034B968 File Offset: 0x00349B68
	private float MaxHp
	{
		get
		{
			if (this.AttrMap == null)
			{
				return this.LastValidMaxHp;
			}
			int valueOrDefault = this.AttrMap.GetValueOrDefault(EKSC_AttrType.LifeMax, 0);
			if (valueOrDefault > 0)
			{
				this.LastValidMaxHp = (float)valueOrDefault;
				return (float)valueOrDefault;
			}
			return this.LastValidMaxHp;
		}
	}

	// Token: 0x0600B273 RID: 45683 RVA: 0x0034B9A8 File Offset: 0x00349BA8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIText)),
			new ValueTuple<int, Type>(12, typeof(UUITexture)),
			new ValueTuple<int, Type>(13, typeof(UUISprite)),
			new ValueTuple<int, Type>(14, typeof(UUIText)),
			new ValueTuple<int, Type>(15, typeof(UUISprite)),
			new ValueTuple<int, Type>(16, typeof(UUISprite)),
			new ValueTuple<int, Type>(17, typeof(UUIText)),
			new ValueTuple<int, Type>(18, typeof(UUIItem)),
			new ValueTuple<int, Type>(19, typeof(UUIText)),
			new ValueTuple<int, Type>(21, typeof(UUIItem)),
			new ValueTuple<int, Type>(20, typeof(UUIItem)),
			new ValueTuple<int, Type>(22, typeof(UUISprite)),
			new ValueTuple<int, Type>(23, typeof(UUIItem)),
			new ValueTuple<int, Type>(24, typeof(UUIItem)),
			new ValueTuple<int, Type>(25, typeof(UUIItem)),
			new ValueTuple<int, Type>(26, typeof(UUITexture)),
			new ValueTuple<int, Type>(27, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.OnBtnQuitClicked)),
			new ValueTuple<int, Delegate>(8, new Action(this.OnBtnMonsterClicked)),
			new ValueTuple<int, Delegate>(9, new Action(this.OnBtnInfoClicked))
		};
	}

	// Token: 0x0600B274 RID: 45684 RVA: 0x0034BC90 File Offset: 0x00349E90
	protected override UniTask OnBeforeStartAsync()
	{
		KurotatoMainPanel.<OnBeforeStartAsync>d__35 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoMainPanel.<OnBeforeStartAsync>d__35>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B275 RID: 45685 RVA: 0x0034BCD4 File Offset: 0x00349ED4
	protected override void OnStart()
	{
		this.SpriteExpBar = base.GetSprite(13);
		this.SpriteLowHpBar = base.GetSprite(22);
		this.SpriteHpBar = base.GetSprite(16);
		this.HpBufferSprite = base.GetSprite(15);
		this.TextHpNum = base.GetText(17);
		this.TextHpNum2 = base.GetText(19);
		this.ComboNumText = base.GetText(7);
		this.PanelKillNum = base.GetItem(23);
		this.PanelKillNum.SetUIActive(false);
		this.HpTextMask = (base.GetItem(18).GetOwner().GetComponentByClass(ULGUICanvas.StaticClass()) as ULGUICanvas);
		this.HpTextWidth = this.TextHpNum.GetWidth();
		this.HpBufferAnimDuration = (float)ConfigCommonParamById.GetIntConfig("PlayerHPAttenuateBufferSpeed").GetValueOrDefault();
		this.ChestCountPanel.SetUiActive(false);
		this.LevelUpCountPanel.SetUiActive(false);
		base.GetItem(5).SetUIActive(false);
		base.GetItem(10).SetUIActive(false);
		base.GetItem(24).SetUIActive(false);
		base.GetItem(25).SetUIActive(false);
		base.GetItem(3).SetUIActive(false);
		this.InitActivityConfig();
		this.InitHpBar();
		this.SeqPlayer = new LevelSequencePlayer(base.GetRootItem());
		this.SeqPlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
	}

	// Token: 0x0600B276 RID: 45686 RVA: 0x0034BE40 File Offset: 0x0034A040
	protected override void OnBeforeShow()
	{
		this.OnAddEventListener();
		this.RefreshAll();
		this.SeqPlayer.PlayOrReplaySequenceByName("Start", false, null);
		if (KurotatoModel.Instance.ConsumeNeedShowSaveTip())
		{
			base.GetItem(10).SetUIActive(true);
			this.SeqPlayer.PlayOrReplaySequenceByName("Save", false, null);
		}
		KurotatoSkillPanel activeSkillPanel = this.GetActiveSkillPanel();
		if (activeSkillPanel == null)
		{
			return;
		}
		activeSkillPanel.ShowBattleChildViewPanel();
	}

	// Token: 0x0600B277 RID: 45687 RVA: 0x0034BEB8 File Offset: 0x0034A0B8
	protected override void OnBeforeHide()
	{
		this.OnRemoveEventListener();
		this.SeqPlayer.StopPlayingSequence(false, false);
		this.KillHoldTimeRemainMs = -1f;
		UUIItem panelKillNum = this.PanelKillNum;
		if (panelKillNum != null)
		{
			panelKillNum.SetUIActive(false);
		}
		base.GetItem(10).SetUIActive(false);
		KurotatoSkillPanel activeSkillPanel = this.GetActiveSkillPanel();
		if (activeSkillPanel == null)
		{
			return;
		}
		activeSkillPanel.HideBattleChildViewPanel();
	}

	// Token: 0x0600B278 RID: 45688 RVA: 0x0034BF13 File Offset: 0x0034A113
	protected override void OnBeforeDestroy()
	{
		KurotatoSkillPanel activeSkillPanel = this.GetActiveSkillPanel();
		if (activeSkillPanel == null)
		{
			return;
		}
		activeSkillPanel.Reset();
	}

	// Token: 0x0600B279 RID: 45689 RVA: 0x0034BF28 File Offset: 0x0034A128
	protected void OnAddEventListener()
	{
		EventSystem.Instance.Add<string, string>(EEventName.TextLanguageChange, new Action<string, string>(this.OnRefreshText));
		EventSystem.Instance.Add(EEventName.OnKscPlayerHpChanged, new Action(this.OnKscPlayerHpChanged));
		EventSystem.Instance.Add(EEventName.SurvivorsRoguePlayerEntityCreated, new Action(this.OnPlayerEntityCreated));
		EventSystem.Instance.Add(EEventName.KurotatoOnSystemInfoUpdate, new Action(this.OnSystemInfoUpdate));
	}

	// Token: 0x0600B27A RID: 45690 RVA: 0x0034BFA8 File Offset: 0x0034A1A8
	protected void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.TextLanguageChange, new Action<string, string>(this.OnRefreshText));
		EventSystem.Instance.Remove(EEventName.OnKscPlayerHpChanged, new Action(this.OnKscPlayerHpChanged));
		EventSystem.Instance.Remove(EEventName.SurvivorsRoguePlayerEntityCreated, new Action(this.OnPlayerEntityCreated));
		EventSystem.Instance.Remove(EEventName.KurotatoOnSystemInfoUpdate, new Action(this.OnSystemInfoUpdate));
	}

	// Token: 0x0600B27B RID: 45691 RVA: 0x0034C028 File Offset: 0x0034A228
	public void OnTick(float delta)
	{
		this.LerpBarPercent(delta);
		this.TickKillHold(delta);
		KurotatoSkillPanel activeSkillPanel = this.GetActiveSkillPanel();
		if (activeSkillPanel != null && activeSkillPanel.GetVisible())
		{
			activeSkillPanel.OnTickBattleChildViewPanel(delta);
		}
	}

	// Token: 0x0600B27C RID: 45692 RVA: 0x0034C05C File Offset: 0x0034A25C
	private void TickKillHold(float delta)
	{
		if (this.KillHoldTimeRemainMs < 0f)
		{
			return;
		}
		this.KillHoldTimeRemainMs -= delta;
		if (this.KillHoldTimeRemainMs <= 0f)
		{
			this.KillHoldTimeRemainMs = -1f;
			this.SeqPlayer.PlayOrReplaySequenceByName("KillClose", false, null);
		}
	}

	// Token: 0x0600B27D RID: 45693 RVA: 0x0034C0B8 File Offset: 0x0034A2B8
	private UniTask CreateMobileSkillPanel()
	{
		KurotatoMainPanel.<CreateMobileSkillPanel>d__44 <CreateMobileSkillPanel>d__;
		<CreateMobileSkillPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateMobileSkillPanel>d__.<>4__this = this;
		<CreateMobileSkillPanel>d__.<>1__state = -1;
		<CreateMobileSkillPanel>d__.<>t__builder.Start<KurotatoMainPanel.<CreateMobileSkillPanel>d__44>(ref <CreateMobileSkillPanel>d__);
		return <CreateMobileSkillPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B27E RID: 45694 RVA: 0x0034C0FC File Offset: 0x0034A2FC
	private UniTask CreateDesktopSkillPanel()
	{
		KurotatoMainPanel.<CreateDesktopSkillPanel>d__45 <CreateDesktopSkillPanel>d__;
		<CreateDesktopSkillPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateDesktopSkillPanel>d__.<>4__this = this;
		<CreateDesktopSkillPanel>d__.<>1__state = -1;
		<CreateDesktopSkillPanel>d__.<>t__builder.Start<KurotatoMainPanel.<CreateDesktopSkillPanel>d__45>(ref <CreateDesktopSkillPanel>d__);
		return <CreateDesktopSkillPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B27F RID: 45695 RVA: 0x0034C140 File Offset: 0x0034A340
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	private UniTask<KurotatoSkillPanel> CreateSkillPanel(string resourceId, EBattleUiChild childType)
	{
		KurotatoMainPanel.<CreateSkillPanel>d__46 <CreateSkillPanel>d__;
		<CreateSkillPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder<KurotatoSkillPanel>.Create();
		<CreateSkillPanel>d__.<>4__this = this;
		<CreateSkillPanel>d__.resourceId = resourceId;
		<CreateSkillPanel>d__.childType = childType;
		<CreateSkillPanel>d__.<>1__state = -1;
		<CreateSkillPanel>d__.<>t__builder.Start<KurotatoMainPanel.<CreateSkillPanel>d__46>(ref <CreateSkillPanel>d__);
		return <CreateSkillPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B280 RID: 45696 RVA: 0x0034C193 File Offset: 0x0034A393
	[NullableContext(2)]
	private KurotatoSkillPanel GetActiveSkillPanel()
	{
		return this.MobileSkillPanel ?? this.DesktopSkillPanel;
	}

	// Token: 0x0600B281 RID: 45697 RVA: 0x0034C1A5 File Offset: 0x0034A3A5
	private void OnBtnQuitClicked()
	{
		UiManager.Instance.OpenView(EUiViewName.KurotatoPauseView, null, null);
	}

	// Token: 0x0600B282 RID: 45698 RVA: 0x0034C1B8 File Offset: 0x0034A3B8
	private void OnBtnMonsterClicked()
	{
		KurotatoModel instance = KurotatoModel.Instance;
		if (instance.GetIsSpecialWave())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Flying_Tip", Array.Empty<object>());
			return;
		}
		KurotatoEnemyDetailBookMainViewOpenParam param = new KurotatoEnemyDetailBookMainViewOpenParam
		{
			TargetLevel = instance.GetCurLevelId(),
			TargetWave = instance.CurWaveNum
		};
		UiManager.Instance.OpenView(EUiViewName.KurotatoEnemyDetailBookMainView, param, null);
	}

	// Token: 0x0600B283 RID: 45699 RVA: 0x0034C217 File Offset: 0x0034A417
	private void OnBtnInfoClicked()
	{
		UiManager.Instance.OpenView(EUiViewName.KurotatoTabMainView, null, null);
	}

	// Token: 0x0600B284 RID: 45700 RVA: 0x0034C22A File Offset: 0x0034A42A
	private void OnRefreshText(string oldLang, string newLang)
	{
		this.RefreshHpAndShield(false);
	}

	// Token: 0x0600B285 RID: 45701 RVA: 0x0034C233 File Offset: 0x0034A433
	private void OnKscPlayerHpChanged()
	{
		this.RefreshHpAndShield(true);
	}

	// Token: 0x0600B286 RID: 45702 RVA: 0x0034C23C File Offset: 0x0034A43C
	private void OnPlayerEntityCreated()
	{
		this.InitPlayerData();
	}

	// Token: 0x0600B287 RID: 45703 RVA: 0x0034C244 File Offset: 0x0034A444
	private void OnSystemInfoUpdate()
	{
		this.RefreshAll();
	}

	// Token: 0x0600B288 RID: 45704 RVA: 0x0034C24C File Offset: 0x0034A44C
	public void RefreshAll()
	{
		this.InitPlayerData();
		this.RefreshRoleHead();
		this.RefreshExp();
		this.RefreshChestCount(KurotatoModel.Instance.BattleData.GetChestCount(), false);
		this.RefreshLevelUpCount(KurotatoModel.Instance.BattleData.GetUpgradeCount(), false);
		this.RefreshCurrencyNum(KurotatoModel.Instance.BattleData.GetCurrencyCount(), 0);
		this.RefreshSpareGold(KurotatoModel.Instance.BattleData.GetSpareGold(), 0);
	}

	// Token: 0x0600B289 RID: 45705 RVA: 0x0034C2C4 File Offset: 0x0034A4C4
	public void RefreshRoleHead()
	{
		int roleId = KurotatoModel.Instance.GetRoleId();
		RoleDataBase roleDataByKurotatoRoleId = KurotatoModel.Instance.GetRoleDataByKurotatoRoleId(roleId);
		base.SetTextureByPath(SkinConfig.Instance.GetRoleSkinConfig(roleDataByKurotatoRoleId.GetRoleSkinId()).Value.RoleHeadIconCircle, base.GetTexture(12), null, null);
	}

	// Token: 0x0600B28A RID: 45706 RVA: 0x0034C324 File Offset: 0x0034A524
	public void RefreshExp()
	{
		KurotatoModel instance = KurotatoModel.Instance;
		KurotatoConfig instance2 = KurotatoConfig.Instance;
		int curLevelId = instance.GetCurLevelId();
		if (curLevelId == 0)
		{
			this.SetExpBarFill(0f);
			return;
		}
		int roleLevel = instance.BattleData.GetRoleLevel();
		int roleExp = instance.BattleData.GetRoleExp();
		KurotatoLevel value = instance2.GetLevelConfig(curLevelId).Value;
		int maxLevel = instance2.GetMaxLevel(value.ActivityId);
		if (roleLevel <= 0)
		{
			this.SetExpBarFill(0f);
		}
		else if (roleLevel >= maxLevel)
		{
			this.SetExpBarFill(1f);
		}
		else
		{
			int expByLevel = instance2.GetExpByLevel(roleLevel, value.ActivityId);
			int expByLevel2 = instance2.GetExpByLevel(roleLevel + 1, value.ActivityId);
			float expBarFill = (float)(roleExp - expByLevel) / (float)(expByLevel2 - expByLevel);
			this.SetExpBarFill(expBarFill);
		}
		base.GetText(14).SetText(roleLevel.ToString(), true);
	}

	// Token: 0x0600B28B RID: 45707 RVA: 0x0034C400 File Offset: 0x0034A600
	private void SetExpBarFill(float percent)
	{
		float fillAmount = MathUtils.Instance.Lerp(0.1f, 0.68f, percent);
		this.SpriteExpBar.SetFillAmount(fillAmount);
		base.GetTexture(26).SetFillAmount(fillAmount);
	}

	// Token: 0x0600B28C RID: 45708 RVA: 0x0034C440 File Offset: 0x0034A640
	public void PlayLvUpAnim()
	{
		this.SeqPlayer.PlayOrReplaySequenceByName("LvUp", false, null);
	}

	// Token: 0x0600B28D RID: 45709 RVA: 0x0034C468 File Offset: 0x0034A668
	public void RefreshCurrencyNum(int currencyNum, int increment = 0)
	{
		base.GetText(2).SetText(currencyNum.ToString(), true);
		if (increment > 0)
		{
			this.SeqPlayer.PlayOrReplaySequenceByName("Coin", false, null);
			this.SeqPlayer.PlayOrReplaySequenceByName("Coin02", false, null);
		}
	}

	// Token: 0x0600B28E RID: 45710 RVA: 0x0034C4C4 File Offset: 0x0034A6C4
	public void RefreshSpareGold(int spareGold, int increment = 0)
	{
		base.GetText(4).SetText(spareGold.ToString(), true);
		base.GetItem(24).SetUIActive(spareGold > 0);
		if (increment > 0)
		{
			UUIText text = base.GetText(6);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendLiteral("+");
			defaultInterpolatedStringHandler.AppendFormatted<int>(increment);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			this.SeqPlayer.PlayOrReplaySequenceByName("Coin02", false, null);
		}
		base.GetItem(3).SetUIActive(increment < 0);
		if (increment < 0)
		{
			this.SeqPlayer.PlayOrReplaySequenceByName("CoinX2", false, null);
		}
	}

	// Token: 0x0600B28F RID: 45711 RVA: 0x0034C574 File Offset: 0x0034A774
	public void RefreshComboNum(int comboNum)
	{
		if (!this.ConsecutiveKillStartShowNumArray.Contains(comboNum))
		{
			return;
		}
		this.ComboNumText.SetText(comboNum.ToString(), true);
		if (this.SeqPlayer.IsPlayingSequence("KillStart") || this.SeqPlayer.IsPlayingSequence("KillMore") || this.SeqPlayer.IsPlayingSequence("KillClose") || this.KillHoldTimeRemainMs >= 0f)
		{
			this.KillHoldTimeRemainMs = -1f;
			this.SeqPlayer.PlayOrReplaySequenceByName("KillMore", false, null);
			return;
		}
		this.PanelKillNum.SetUIActive(true);
		this.SeqPlayer.PlayOrReplaySequenceByName("KillStart", false, null);
	}

	// Token: 0x0600B290 RID: 45712 RVA: 0x0034C63A File Offset: 0x0034A83A
	private void OnSequenceClose(string sequenceName)
	{
		if (sequenceName == "KillStart" || sequenceName == "KillMore")
		{
			this.KillHoldTimeRemainMs = this.ConsecutiveKillHoldDuration;
		}
	}

	// Token: 0x0600B291 RID: 45713 RVA: 0x0034C662 File Offset: 0x0034A862
	public void RefreshChestCount(int count, bool bPlayAcquireAnim = false)
	{
		this.ChestCountPanel.SetUiActive(count > 0);
		this.ChestCountPanel.Refresh(count);
		if (bPlayAcquireAnim)
		{
			this.ChestCountPanel.PlayAcquireAnim();
		}
	}

	// Token: 0x0600B292 RID: 45714 RVA: 0x0034C68D File Offset: 0x0034A88D
	public void RefreshLevelUpCount(int count, bool bPlayAcquireAnim = false)
	{
		this.LevelUpCountPanel.SetUiActive(count > 0);
		this.LevelUpCountPanel.Refresh(count);
		if (bPlayAcquireAnim)
		{
			this.LevelUpCountPanel.PlayAcquireAnim();
		}
	}

	// Token: 0x0600B293 RID: 45715 RVA: 0x0034C6B8 File Offset: 0x0034A8B8
	public void InitPlayerData()
	{
		KscSubModelBase curSubModel = KuroSimpleCombatController.Instance.CurSubModel;
		AKSC_Entity aksc_Entity = (curSubModel != null) ? curSubModel.KscPlayerEntity : null;
		if (aksc_Entity == null)
		{
			return;
		}
		UKSC_SkillComp skillComp = aksc_Entity.GetSkillComp();
		TMap<EKSC_AttrType, int> tmap;
		if (skillComp == null)
		{
			tmap = null;
		}
		else
		{
			UKSC_AttrSet attrSet_ = skillComp.AttrSet_;
			tmap = ((attrSet_ != null) ? attrSet_.Attrs_ : null);
		}
		TMap<EKSC_AttrType, int> tmap2 = tmap;
		if (tmap2 == null)
		{
			return;
		}
		this.AttrMap = tmap2;
		this.RefreshHpAndShield(false);
		base.GetItem(25).SetUIActive(true);
	}

	// Token: 0x0600B294 RID: 45716 RVA: 0x0034C720 File Offset: 0x0034A920
	private void InitActivityConfig()
	{
		KurotatoActivityConfig? activityConfig = KurotatoModel.Instance.GetActivityConfig();
		if (activityConfig == null)
		{
			return;
		}
		this.ConsecutiveKillStartShowNumArray.Clear();
		foreach (int num in activityConfig.Value.GetConsecutiveKillStartShowNumArrayArray())
		{
			if (num > 0)
			{
				this.ConsecutiveKillStartShowNumArray.Add(num);
			}
		}
		this.ConsecutiveKillStartShowNumArray.Sort();
		this.ConsecutiveKillHoldDuration = (float)activityConfig.Value.ConsecutiveKillHoldDuration;
	}

	// Token: 0x0600B295 RID: 45717 RVA: 0x0034C7A3 File Offset: 0x0034A9A3
	private void InitHpBar()
	{
		this.SpriteLowHpBar.SetUIActive(false);
		this.SpriteHpBar.SetUIActive(true);
	}

	// Token: 0x0600B296 RID: 45718 RVA: 0x0034C7C0 File Offset: 0x0034A9C0
	private void RefreshHpAndShield(bool bPlayBarAnimation = false)
	{
		if (this.AttrMap == null)
		{
			return;
		}
		float num = this.CurHp / this.MaxHp;
		this.UeMargin.Right = -(1f - num) * this.HpTextWidth;
		this.HpTextMask.SetRectClipOffset(this.UeMargin);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>((int)Math.Ceiling((double)this.CurHp));
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>((int)Math.Ceiling((double)this.MaxHp));
		string newText = defaultInterpolatedStringHandler.ToStringAndClear();
		this.TextHpNum.SetText(newText, true);
		this.TextHpNum2.SetText(newText, true);
		this.SetHpBarPercent(num);
		if (bPlayBarAnimation)
		{
			this.PlayBarAnimation();
		}
		else
		{
			this.StopBarLerpAnimation();
		}
		this.CurrentBarPercent = num;
	}

	// Token: 0x0600B297 RID: 45719 RVA: 0x0034C890 File Offset: 0x0034AA90
	private void SetHpBarPercent(float percent)
	{
		if (percent <= 0.2f)
		{
			this.SpriteLowHpBar.SetUIActive(true);
			this.SpriteHpBar.SetUIActive(false);
			this.SpriteLowHpBar.SetFillAmount(percent);
			return;
		}
		this.SpriteLowHpBar.SetUIActive(false);
		this.SpriteHpBar.SetUIActive(true);
		this.SpriteHpBar.SetFillAmount(percent);
	}

	// Token: 0x0600B298 RID: 45720 RVA: 0x0034C8F0 File Offset: 0x0034AAF0
	private void PlayBarAnimation()
	{
		if (this.AttrMap == null)
		{
			return;
		}
		float num = this.CurHp / this.MaxHp;
		float currentBarPercent = this.CurrentBarPercent;
		if (num >= currentBarPercent)
		{
			return;
		}
		this.TargetBarPercent = num;
		this.SourceBarPercent = currentBarPercent;
		this.HpBufferAnimTime = 0f;
	}

	// Token: 0x0600B299 RID: 45721 RVA: 0x0034C939 File Offset: 0x0034AB39
	private void StopBarLerpAnimation()
	{
		this.TargetBarPercent = 0f;
		this.SourceBarPercent = 0f;
		this.HpBufferAnimTime = -1f;
		this.HpBufferSprite.SetUIActive(false);
	}

	// Token: 0x0600B29A RID: 45722 RVA: 0x0034C968 File Offset: 0x0034AB68
	private void LerpBarPercent(float delta)
	{
		if (this.HpBufferAnimTime == -1f)
		{
			return;
		}
		if (this.HpBufferAnimTime >= this.HpBufferAnimDuration)
		{
			this.StopBarLerpAnimation();
			return;
		}
		if (this.TargetBarPercent >= this.SourceBarPercent)
		{
			return;
		}
		float alpha = this.HpBufferAnimTime / this.HpBufferAnimDuration;
		float fillAmount = MathUtils.Instance.Lerp(this.SourceBarPercent, this.TargetBarPercent, alpha);
		this.HpBufferSprite.SetFillAmount(fillAmount);
		this.HpBufferSprite.SetUIActive(true);
		this.HpBufferAnimTime += delta;
	}

	// Token: 0x040066F3 RID: 26355
	private const float LOW_HP_PERCENT = 0.2f;

	// Token: 0x040066F4 RID: 26356
	private const float EXP_BAR_FILL_MIN = 0.1f;

	// Token: 0x040066F5 RID: 26357
	private const float EXP_BAR_FILL_MAX = 0.68f;

	// Token: 0x040066F6 RID: 26358
	private UUISprite SpriteExpBar;

	// Token: 0x040066F7 RID: 26359
	private UUISprite SpriteLowHpBar;

	// Token: 0x040066F8 RID: 26360
	private UUISprite SpriteHpBar;

	// Token: 0x040066F9 RID: 26361
	private UUISprite HpBufferSprite;

	// Token: 0x040066FA RID: 26362
	private UUIText TextHpNum;

	// Token: 0x040066FB RID: 26363
	private UUIText TextHpNum2;

	// Token: 0x040066FC RID: 26364
	private ULGUICanvas HpTextMask;

	// Token: 0x040066FD RID: 26365
	private UUIText ComboNumText;

	// Token: 0x040066FE RID: 26366
	private UUIItem PanelKillNum;

	// Token: 0x040066FF RID: 26367
	private float HpTextWidth;

	// Token: 0x04006700 RID: 26368
	private FMargin UeMargin;

	// Token: 0x04006701 RID: 26369
	private List<int> ConsecutiveKillStartShowNumArray = new List<int>();

	// Token: 0x04006702 RID: 26370
	private float ConsecutiveKillHoldDuration;

	// Token: 0x04006703 RID: 26371
	private float KillHoldTimeRemainMs = -1f;

	// Token: 0x04006704 RID: 26372
	private readonly KurotatoCountItemPanel ChestCountPanel = new KurotatoCountItemPanel();

	// Token: 0x04006705 RID: 26373
	private readonly KurotatoCountItemPanel LevelUpCountPanel = new KurotatoCountItemPanel();

	// Token: 0x04006706 RID: 26374
	[Nullable(2)]
	private KurotatoSkillPanel MobileSkillPanel;

	// Token: 0x04006707 RID: 26375
	[Nullable(2)]
	private KurotatoSkillPanel DesktopSkillPanel;

	// Token: 0x04006708 RID: 26376
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x04006709 RID: 26377
	[Nullable(2)]
	private TMap<EKSC_AttrType, int> AttrMap;

	// Token: 0x0400670A RID: 26378
	private float CurrentBarPercent = -1f;

	// Token: 0x0400670B RID: 26379
	private float TargetBarPercent;

	// Token: 0x0400670C RID: 26380
	private float SourceBarPercent;

	// Token: 0x0400670D RID: 26381
	private float HpBufferAnimTime = -1f;

	// Token: 0x0400670E RID: 26382
	private float HpBufferAnimDuration;

	// Token: 0x0400670F RID: 26383
	private float LastValidMaxHp = -1f;

	// Token: 0x0200742F RID: 29743
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04025D0B RID: 154891
		public const int PanelLowHpEffect = 0;

		// Token: 0x04025D0C RID: 154892
		public const int BtnQuit = 1;

		// Token: 0x04025D0D RID: 154893
		public const int TextCurrencyNum = 2;

		// Token: 0x04025D0E RID: 154894
		public const int PanelCurrencyExtra = 3;

		// Token: 0x04025D0F RID: 154895
		public const int TextSpareGoldNum = 4;

		// Token: 0x04025D10 RID: 154896
		public const int PanelSpareGoldAdd = 5;

		// Token: 0x04025D11 RID: 154897
		public const int TextSpareGoldAdd = 6;

		// Token: 0x04025D12 RID: 154898
		public const int TextComboNum = 7;

		// Token: 0x04025D13 RID: 154899
		public const int BtnMonster = 8;

		// Token: 0x04025D14 RID: 154900
		public const int BtnInfo = 9;

		// Token: 0x04025D15 RID: 154901
		public const int PanelSaveTip = 10;

		// Token: 0x04025D16 RID: 154902
		public const int TextSaveTip = 11;

		// Token: 0x04025D17 RID: 154903
		public const int TextureRoleHead = 12;

		// Token: 0x04025D18 RID: 154904
		public const int SpriteExpBar = 13;

		// Token: 0x04025D19 RID: 154905
		public const int TextLevel = 14;

		// Token: 0x04025D1A RID: 154906
		public const int SpriteHpBuffer = 15;

		// Token: 0x04025D1B RID: 154907
		public const int SpriteHpBar = 16;

		// Token: 0x04025D1C RID: 154908
		public const int TextHpNum = 17;

		// Token: 0x04025D1D RID: 154909
		public const int PanelHpMask = 18;

		// Token: 0x04025D1E RID: 154910
		public const int TextHpNum2 = 19;

		// Token: 0x04025D1F RID: 154911
		public const int ItemLevelUpCount = 20;

		// Token: 0x04025D20 RID: 154912
		public const int ItemChestCount = 21;

		// Token: 0x04025D21 RID: 154913
		public const int SpriteLowHpBar = 22;

		// Token: 0x04025D22 RID: 154914
		public const int PanelKillNum = 23;

		// Token: 0x04025D23 RID: 154915
		public const int PanelGoldAdd = 24;

		// Token: 0x04025D24 RID: 154916
		public const int PanelRoleInfo = 25;

		// Token: 0x04025D25 RID: 154917
		public const int TextureFxGlow = 26;

		// Token: 0x04025D26 RID: 154918
		public const int Content = 27;
	}
}
