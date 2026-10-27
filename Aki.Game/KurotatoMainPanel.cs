using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x02001CBC RID: 7356
[NullableContext(1)]
[Nullable(0)]
public class KurotatoMainPanel : UiPanelBase
{
	// Token: 0x17001205 RID: 4613
	// (get) Token: 0x0600DE54 RID: 56916 RVA: 0x0033FEF4 File Offset: 0x0033E0F4
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

	// Token: 0x17001206 RID: 4614
	// (get) Token: 0x0600DE55 RID: 56917 RVA: 0x0033FF2C File Offset: 0x0033E12C
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

	// Token: 0x0600DE56 RID: 56918 RVA: 0x0033FF6C File Offset: 0x0033E16C
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

	// Token: 0x0600DE57 RID: 56919 RVA: 0x00340254 File Offset: 0x0033E454
	protected override UniTask OnBeforeStartAsync()
	{
		KurotatoMainPanel.<OnBeforeStartAsync>d__35 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoMainPanel.<OnBeforeStartAsync>d__35>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DE58 RID: 56920 RVA: 0x00340298 File Offset: 0x0033E498
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

	// Token: 0x0600DE59 RID: 56921 RVA: 0x00340404 File Offset: 0x0033E604
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

	// Token: 0x0600DE5A RID: 56922 RVA: 0x0034047C File Offset: 0x0033E67C
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

	// Token: 0x0600DE5B RID: 56923 RVA: 0x003404D7 File Offset: 0x0033E6D7
	protected override void OnBeforeDestroy()
	{
		KurotatoSkillPanel activeSkillPanel = this.GetActiveSkillPanel();
		if (activeSkillPanel == null)
		{
			return;
		}
		activeSkillPanel.Reset();
	}

	// Token: 0x0600DE5C RID: 56924 RVA: 0x003404EC File Offset: 0x0033E6EC
	protected void OnAddEventListener()
	{
		EventSystem.Instance.Add<string, string>(EEventName.TextLanguageChange, new Action<string, string>(this.OnRefreshText));
		EventSystem.Instance.Add(EEventName.OnKscPlayerHpChanged, new Action(this.OnKscPlayerHpChanged));
		EventSystem.Instance.Add(EEventName.SurvivorsRoguePlayerEntityCreated, new Action(this.OnPlayerEntityCreated));
		EventSystem.Instance.Add(EEventName.KurotatoOnSystemInfoUpdate, new Action(this.OnSystemInfoUpdate));
	}

	// Token: 0x0600DE5D RID: 56925 RVA: 0x0034056C File Offset: 0x0033E76C
	protected void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.TextLanguageChange, new Action<string, string>(this.OnRefreshText));
		EventSystem.Instance.Remove(EEventName.OnKscPlayerHpChanged, new Action(this.OnKscPlayerHpChanged));
		EventSystem.Instance.Remove(EEventName.SurvivorsRoguePlayerEntityCreated, new Action(this.OnPlayerEntityCreated));
		EventSystem.Instance.Remove(EEventName.KurotatoOnSystemInfoUpdate, new Action(this.OnSystemInfoUpdate));
	}

	// Token: 0x0600DE5E RID: 56926 RVA: 0x003405EC File Offset: 0x0033E7EC
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

	// Token: 0x0600DE5F RID: 56927 RVA: 0x00340620 File Offset: 0x0033E820
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

	// Token: 0x0600DE60 RID: 56928 RVA: 0x0034067C File Offset: 0x0033E87C
	private UniTask CreateMobileSkillPanel()
	{
		KurotatoMainPanel.<CreateMobileSkillPanel>d__44 <CreateMobileSkillPanel>d__;
		<CreateMobileSkillPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateMobileSkillPanel>d__.<>4__this = this;
		<CreateMobileSkillPanel>d__.<>1__state = -1;
		<CreateMobileSkillPanel>d__.<>t__builder.Start<KurotatoMainPanel.<CreateMobileSkillPanel>d__44>(ref <CreateMobileSkillPanel>d__);
		return <CreateMobileSkillPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600DE61 RID: 56929 RVA: 0x003406C0 File Offset: 0x0033E8C0
	private UniTask CreateDesktopSkillPanel()
	{
		KurotatoMainPanel.<CreateDesktopSkillPanel>d__45 <CreateDesktopSkillPanel>d__;
		<CreateDesktopSkillPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateDesktopSkillPanel>d__.<>4__this = this;
		<CreateDesktopSkillPanel>d__.<>1__state = -1;
		<CreateDesktopSkillPanel>d__.<>t__builder.Start<KurotatoMainPanel.<CreateDesktopSkillPanel>d__45>(ref <CreateDesktopSkillPanel>d__);
		return <CreateDesktopSkillPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600DE62 RID: 56930 RVA: 0x00340704 File Offset: 0x0033E904
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

	// Token: 0x0600DE63 RID: 56931 RVA: 0x00340757 File Offset: 0x0033E957
	[NullableContext(2)]
	private KurotatoSkillPanel GetActiveSkillPanel()
	{
		return this.MobileSkillPanel ?? this.DesktopSkillPanel;
	}

	// Token: 0x0600DE64 RID: 56932 RVA: 0x00340769 File Offset: 0x0033E969
	private void OnBtnQuitClicked()
	{
		UiManager.Instance.OpenView(EUiViewName.KurotatoPauseView, null, null);
	}

	// Token: 0x0600DE65 RID: 56933 RVA: 0x0034077C File Offset: 0x0033E97C
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

	// Token: 0x0600DE66 RID: 56934 RVA: 0x003407DB File Offset: 0x0033E9DB
	private void OnBtnInfoClicked()
	{
		UiManager.Instance.OpenView(EUiViewName.KurotatoTabMainView, null, null);
	}

	// Token: 0x0600DE67 RID: 56935 RVA: 0x003407EE File Offset: 0x0033E9EE
	private void OnRefreshText(string oldLang, string newLang)
	{
		this.RefreshHpAndShield(false);
	}

	// Token: 0x0600DE68 RID: 56936 RVA: 0x003407F7 File Offset: 0x0033E9F7
	private void OnKscPlayerHpChanged()
	{
		this.RefreshHpAndShield(true);
	}

	// Token: 0x0600DE69 RID: 56937 RVA: 0x00340800 File Offset: 0x0033EA00
	private void OnPlayerEntityCreated()
	{
		this.InitPlayerData();
	}

	// Token: 0x0600DE6A RID: 56938 RVA: 0x00340808 File Offset: 0x0033EA08
	private void OnSystemInfoUpdate()
	{
		this.RefreshAll();
	}

	// Token: 0x0600DE6B RID: 56939 RVA: 0x00340810 File Offset: 0x0033EA10
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

	// Token: 0x0600DE6C RID: 56940 RVA: 0x00340888 File Offset: 0x0033EA88
	public void RefreshRoleHead()
	{
		int roleId = KurotatoModel.Instance.GetRoleId();
		RoleDataBase roleDataByKurotatoRoleId = KurotatoModel.Instance.GetRoleDataByKurotatoRoleId(roleId);
		base.SetTextureByPath(SkinConfig.Instance.GetRoleSkinConfig(roleDataByKurotatoRoleId.GetRoleSkinId()).Value.RoleHeadIconCircle, base.GetTexture(12), null, null);
	}

	// Token: 0x0600DE6D RID: 56941 RVA: 0x003408E8 File Offset: 0x0033EAE8
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

	// Token: 0x0600DE6E RID: 56942 RVA: 0x003409C4 File Offset: 0x0033EBC4
	private void SetExpBarFill(float percent)
	{
		float fillAmount = MathUtils.Instance.Lerp(0.1f, 0.68f, percent);
		this.SpriteExpBar.SetFillAmount(fillAmount);
		base.GetTexture(26).SetFillAmount(fillAmount);
	}

	// Token: 0x0600DE6F RID: 56943 RVA: 0x00340A04 File Offset: 0x0033EC04
	public void PlayLvUpAnim()
	{
		this.SeqPlayer.PlayOrReplaySequenceByName("LvUp", false, null);
	}

	// Token: 0x0600DE70 RID: 56944 RVA: 0x00340A2C File Offset: 0x0033EC2C
	public void RefreshCurrencyNum(int currencyNum, int increment = 0)
	{
		base.GetText(2).SetText(currencyNum.ToString(), true);
		if (increment > 0)
		{
			this.SeqPlayer.PlayOrReplaySequenceByName("Coin", false, null);
			this.SeqPlayer.PlayOrReplaySequenceByName("Coin02", false, null);
		}
	}

	// Token: 0x0600DE71 RID: 56945 RVA: 0x00340A88 File Offset: 0x0033EC88
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

	// Token: 0x0600DE72 RID: 56946 RVA: 0x00340B38 File Offset: 0x0033ED38
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

	// Token: 0x0600DE73 RID: 56947 RVA: 0x00340BFE File Offset: 0x0033EDFE
	private void OnSequenceClose(string sequenceName)
	{
		if (sequenceName == "KillStart" || sequenceName == "KillMore")
		{
			this.KillHoldTimeRemainMs = this.ConsecutiveKillHoldDuration;
		}
	}

	// Token: 0x0600DE74 RID: 56948 RVA: 0x00340C26 File Offset: 0x0033EE26
	public void RefreshChestCount(int count, bool bPlayAcquireAnim = false)
	{
		this.ChestCountPanel.SetUiActive(count > 0);
		this.ChestCountPanel.Refresh(count);
		if (bPlayAcquireAnim)
		{
			this.ChestCountPanel.PlayAcquireAnim();
		}
	}

	// Token: 0x0600DE75 RID: 56949 RVA: 0x00340C51 File Offset: 0x0033EE51
	public void RefreshLevelUpCount(int count, bool bPlayAcquireAnim = false)
	{
		this.LevelUpCountPanel.SetUiActive(count > 0);
		this.LevelUpCountPanel.Refresh(count);
		if (bPlayAcquireAnim)
		{
			this.LevelUpCountPanel.PlayAcquireAnim();
		}
	}

	// Token: 0x0600DE76 RID: 56950 RVA: 0x00340C7C File Offset: 0x0033EE7C
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

	// Token: 0x0600DE77 RID: 56951 RVA: 0x00340CE4 File Offset: 0x0033EEE4
	private void InitActivityConfig()
	{
		KurotatoActivityConfig? activityConfig = KurotatoModel.Instance.GetActivityConfig();
		if (activityConfig == null)
		{
			return;
		}
		this.ConsecutiveKillStartShowNumArray = (from showNum in activityConfig.Value.GetConsecutiveKillStartShowNumArrayArray()
		where showNum > 0
		select showNum into num
		orderby num
		select num).ToList<int>();
		this.ConsecutiveKillHoldDuration = (float)activityConfig.Value.ConsecutiveKillHoldDuration;
	}

	// Token: 0x0600DE78 RID: 56952 RVA: 0x00340D7E File Offset: 0x0033EF7E
	private void InitHpBar()
	{
		this.SpriteLowHpBar.SetUIActive(false);
		this.SpriteHpBar.SetUIActive(true);
	}

	// Token: 0x0600DE79 RID: 56953 RVA: 0x00340D98 File Offset: 0x0033EF98
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

	// Token: 0x0600DE7A RID: 56954 RVA: 0x00340E68 File Offset: 0x0033F068
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

	// Token: 0x0600DE7B RID: 56955 RVA: 0x00340EC8 File Offset: 0x0033F0C8
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

	// Token: 0x0600DE7C RID: 56956 RVA: 0x00340F11 File Offset: 0x0033F111
	private void StopBarLerpAnimation()
	{
		this.TargetBarPercent = 0f;
		this.SourceBarPercent = 0f;
		this.HpBufferAnimTime = -1f;
		this.HpBufferSprite.SetUIActive(false);
	}

	// Token: 0x0600DE7D RID: 56957 RVA: 0x00340F40 File Offset: 0x0033F140
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

	// Token: 0x04006614 RID: 26132
	private const float LOW_HP_PERCENT = 0.2f;

	// Token: 0x04006615 RID: 26133
	private const float EXP_BAR_FILL_MIN = 0.1f;

	// Token: 0x04006616 RID: 26134
	private const float EXP_BAR_FILL_MAX = 0.68f;

	// Token: 0x04006617 RID: 26135
	private UUISprite SpriteExpBar;

	// Token: 0x04006618 RID: 26136
	private UUISprite SpriteLowHpBar;

	// Token: 0x04006619 RID: 26137
	private UUISprite SpriteHpBar;

	// Token: 0x0400661A RID: 26138
	private UUISprite HpBufferSprite;

	// Token: 0x0400661B RID: 26139
	private UUIText TextHpNum;

	// Token: 0x0400661C RID: 26140
	private UUIText TextHpNum2;

	// Token: 0x0400661D RID: 26141
	private ULGUICanvas HpTextMask;

	// Token: 0x0400661E RID: 26142
	private UUIText ComboNumText;

	// Token: 0x0400661F RID: 26143
	private UUIItem PanelKillNum;

	// Token: 0x04006620 RID: 26144
	private float HpTextWidth;

	// Token: 0x04006621 RID: 26145
	private FMargin UeMargin;

	// Token: 0x04006622 RID: 26146
	private List<int> ConsecutiveKillStartShowNumArray = new List<int>();

	// Token: 0x04006623 RID: 26147
	private float ConsecutiveKillHoldDuration;

	// Token: 0x04006624 RID: 26148
	private float KillHoldTimeRemainMs = -1f;

	// Token: 0x04006625 RID: 26149
	private readonly KurotatoCountItemPanel ChestCountPanel = new KurotatoCountItemPanel();

	// Token: 0x04006626 RID: 26150
	private readonly KurotatoCountItemPanel LevelUpCountPanel = new KurotatoCountItemPanel();

	// Token: 0x04006627 RID: 26151
	[Nullable(2)]
	private KurotatoSkillPanel MobileSkillPanel;

	// Token: 0x04006628 RID: 26152
	[Nullable(2)]
	private KurotatoSkillPanel DesktopSkillPanel;

	// Token: 0x04006629 RID: 26153
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x0400662A RID: 26154
	[Nullable(2)]
	private TMap<EKSC_AttrType, int> AttrMap;

	// Token: 0x0400662B RID: 26155
	private float CurrentBarPercent = -1f;

	// Token: 0x0400662C RID: 26156
	private float TargetBarPercent;

	// Token: 0x0400662D RID: 26157
	private float SourceBarPercent;

	// Token: 0x0400662E RID: 26158
	private float HpBufferAnimTime = -1f;

	// Token: 0x0400662F RID: 26159
	private float HpBufferAnimDuration;

	// Token: 0x04006630 RID: 26160
	private float LastValidMaxHp = -1f;

	// Token: 0x020082A5 RID: 33445
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402A9E0 RID: 174560
		public const int PanelLowHpEffect = 0;

		// Token: 0x0402A9E1 RID: 174561
		public const int BtnQuit = 1;

		// Token: 0x0402A9E2 RID: 174562
		public const int TextCurrencyNum = 2;

		// Token: 0x0402A9E3 RID: 174563
		public const int PanelCurrencyExtra = 3;

		// Token: 0x0402A9E4 RID: 174564
		public const int TextSpareGoldNum = 4;

		// Token: 0x0402A9E5 RID: 174565
		public const int PanelSpareGoldAdd = 5;

		// Token: 0x0402A9E6 RID: 174566
		public const int TextSpareGoldAdd = 6;

		// Token: 0x0402A9E7 RID: 174567
		public const int TextComboNum = 7;

		// Token: 0x0402A9E8 RID: 174568
		public const int BtnMonster = 8;

		// Token: 0x0402A9E9 RID: 174569
		public const int BtnInfo = 9;

		// Token: 0x0402A9EA RID: 174570
		public const int PanelSaveTip = 10;

		// Token: 0x0402A9EB RID: 174571
		public const int TextSaveTip = 11;

		// Token: 0x0402A9EC RID: 174572
		public const int TextureRoleHead = 12;

		// Token: 0x0402A9ED RID: 174573
		public const int SpriteExpBar = 13;

		// Token: 0x0402A9EE RID: 174574
		public const int TextLevel = 14;

		// Token: 0x0402A9EF RID: 174575
		public const int SpriteHpBuffer = 15;

		// Token: 0x0402A9F0 RID: 174576
		public const int SpriteHpBar = 16;

		// Token: 0x0402A9F1 RID: 174577
		public const int TextHpNum = 17;

		// Token: 0x0402A9F2 RID: 174578
		public const int PanelHpMask = 18;

		// Token: 0x0402A9F3 RID: 174579
		public const int TextHpNum2 = 19;

		// Token: 0x0402A9F4 RID: 174580
		public const int ItemLevelUpCount = 20;

		// Token: 0x0402A9F5 RID: 174581
		public const int ItemChestCount = 21;

		// Token: 0x0402A9F6 RID: 174582
		public const int SpriteLowHpBar = 22;

		// Token: 0x0402A9F7 RID: 174583
		public const int PanelKillNum = 23;

		// Token: 0x0402A9F8 RID: 174584
		public const int PanelGoldAdd = 24;

		// Token: 0x0402A9F9 RID: 174585
		public const int PanelRoleInfo = 25;

		// Token: 0x0402A9FA RID: 174586
		public const int TextureFxGlow = 26;

		// Token: 0x0402A9FB RID: 174587
		public const int Content = 27;
	}
}
