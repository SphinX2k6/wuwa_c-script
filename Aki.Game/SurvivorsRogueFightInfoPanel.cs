using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001D1D RID: 7453
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueFightInfoPanel : UiPanelBase
{
	// Token: 0x17001218 RID: 4632
	// (get) Token: 0x0600E16C RID: 57708 RVA: 0x0034E780 File Offset: 0x0034C980
	private float ComboDurationTime
	{
		get
		{
			if (this.ComboDurationTimeInternal == 0f)
			{
				return 5000f;
			}
			return this.ComboDurationTimeInternal;
		}
	}

	// Token: 0x0600E16D RID: 57709 RVA: 0x0034E79C File Offset: 0x0034C99C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUISprite)),
			new ValueTuple<int, Type>(4, typeof(UUIArtText)),
			new ValueTuple<int, Type>(5, typeof(UUITexture)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUISprite)),
			new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnQuitButtonClicked)),
			new ValueTuple<int, Delegate>(8, new Action(this.OnSettingButtonClicked))
		};
	}

	// Token: 0x0600E16E RID: 57710 RVA: 0x0034E8E3 File Offset: 0x0034CAE3
	private void OnQuitButtonClicked()
	{
		SurvivorsRogueController.Instance.OpenLeaveInstanceView();
	}

	// Token: 0x0600E16F RID: 57711 RVA: 0x0034E8EF File Offset: 0x0034CAEF
	private void OnSettingButtonClicked()
	{
		UiManager.Instance.OpenView(EUiViewName.MenuView, null, null);
	}

	// Token: 0x0600E170 RID: 57712 RVA: 0x0034E904 File Offset: 0x0034CB04
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsRogueFightInfoPanel.<OnBeforeStartAsync>d__28 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsRogueFightInfoPanel.<OnBeforeStartAsync>d__28>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E171 RID: 57713 RVA: 0x0034E948 File Offset: 0x0034CB48
	protected unsafe override void OnStart()
	{
		this.ComboArea = base.GetItem(9);
		this.PositiveArea = base.GetItem(10);
		this.ComboNumText = base.GetArtText(4);
		this.ComboRemainTimeBarSprite = base.GetSprite(3);
		this.PositiveIcon = base.GetTexture(5);
		this.PositiveText = base.GetText(6);
		this.PositiveArrow = base.GetSprite(7);
		this.CurrencyEfficiencyEnhancePlayer = new LevelSequencePlayer(this.CurrencyCollectionItem.GetRootItem());
		this.CurrencyEfficiencyEnhancePlayer.BindSequenceCloseEvent(delegate(string _)
		{
			this.CurrencyEfficiencyEnhancePlayer.PlayOrReplaySequenceByName("Close", false, null);
		}, false);
		this.ComboPlayer = new LevelSequencePlayer(this.ComboArea);
		this.ComboPlayer.BindSequenceCloseEvent(delegate(string sequenceName)
		{
			if (sequenceName == "Close")
			{
				this.ComboArea.SetUIActive(false);
			}
		}, false);
		this.PositiveAreaPlayer = new LevelSequencePlayer(this.PositiveArea);
		this.PositiveAreaPlayer.BindSequenceCloseEvent(delegate(string sequenceName)
		{
			if (sequenceName == "Close")
			{
				this.PositiveArea.SetUIActive(false);
			}
		}, false);
		this.ComboAnimHandle = new List<Action>
		{
			delegate()
			{
				this.ComboPlayer.StopPlayingSequence(false, true);
				this.ComboPlayer.PlayOrReplaySequenceByName("KillNor", false, null);
			},
			delegate()
			{
				this.ComboPlayer.StopPlayingSequence(false, true);
				this.ComboPlayer.PlayOrReplaySequenceByName("KillMore", false, null);
			},
			delegate()
			{
				this.ComboPlayer.StopPlayingSequence(false, true);
				this.ComboPlayer.PlayOrReplaySequenceByName("KillMost", false, null);
			},
			delegate()
			{
				this.ComboPlayer.StopPlayingSequence(false, true);
				this.ComboPlayer.PlayOrReplaySequenceByName("KillMost", false, null);
			}
		};
		if (this.ComboAnimHandle.Count != 4)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SurvivorsRogue;
			ELogAuthor author = ELogAuthor.CK;
			string message = "幸存者连杀等级配置数量不匹配";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("合法数量", 4);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("实际数量", this.ComboAnimHandle.Count);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		this.ComboArea.SetUIActive(false);
		this.PositiveArea.SetUIActive(false);
		this.CurrencyCollectionItem.SetUiActive(true);
		this.ChestCollectionItem.SetUiActive(false);
	}

	// Token: 0x0600E172 RID: 57714 RVA: 0x0034EB30 File Offset: 0x0034CD30
	protected override void OnBeforeShow()
	{
		SurvivorsRogueBattleData battleData = SurvivorsRogueModel.Instance.BattleData;
		this.RefreshCurrencyNum(battleData.GetCurrencyCount(), false);
		this.RefreshChestNum(battleData.GetChestCount(), false);
		this.TickEnabled = true;
	}

	// Token: 0x0600E173 RID: 57715 RVA: 0x0034EB69 File Offset: 0x0034CD69
	protected override void OnBeforeHide()
	{
		this.TickEnabled = false;
	}

	// Token: 0x0600E174 RID: 57716 RVA: 0x0034EB74 File Offset: 0x0034CD74
	public unsafe void OnTick(float delta)
	{
		if (!this.TickEnabled || !this.NeedTick)
		{
			return;
		}
		if (this.FreezeTime > 0f)
		{
			this.FreezeTime -= delta;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SurvivorsRogue;
			ELogAuthor author = ELogAuthor.CK;
			string message = "连杀时间冻结中";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("剩余冻结时间", this.FreezeTime);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.RemainTime -= delta;
		if (this.RemainTime <= 0f)
		{
			this.NeedTick = false;
			this.SetComboRemainTimeBarPercent(0f);
			return;
		}
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.SurvivorsRogue;
		ELogAuthor author2 = ELogAuthor.CK;
		string message2 = "连杀时间进度更新";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("RemainTime", this.RemainTime);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ComboDurationTime", this.ComboDurationTime);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Percent", this.RemainTime / this.ComboDurationTime);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		this.SetComboRemainTimeBarPercent(this.RemainTime / this.ComboDurationTime);
	}

	// Token: 0x0600E175 RID: 57717 RVA: 0x0034ECB6 File Offset: 0x0034CEB6
	public void ResetFightInfo()
	{
		this.RefreshComboNum(0);
		this.RefreshPositiveArea(0);
	}

	// Token: 0x0600E176 RID: 57718 RVA: 0x0034ECC8 File Offset: 0x0034CEC8
	public void RefreshComboNum(int comboNum)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.SurvivorsRogue;
		ELogAuthor author = ELogAuthor.CK;
		string message = "RefreshComboNum";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ComboNum", comboNum);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (comboNum == 0)
		{
			this.FreezeTime = 0f;
			this.RemainTime = 0f;
			this.SetComboRemainTimeBarPercent(0f);
			this.SetComboAreaActive(false, this.CurComboNum > 0);
			this.NeedTick = false;
			this.CurComboNum = 0;
		}
		else
		{
			this.ComboNumText.SetText(comboNum.ToString());
			this.SetComboRemainTimeBarPercent(1f);
			this.SetComboAreaActive(true, this.CurComboNum == 0);
			this.NeedTick = true;
			this.CurComboNum = comboNum;
		}
		this.UpdateComboDurationInfo(comboNum);
	}

	// Token: 0x0600E177 RID: 57719 RVA: 0x0034ED8C File Offset: 0x0034CF8C
	private unsafe void UpdateComboDurationInfo(int comboNum)
	{
		SurvivorsRogueModel instance = SurvivorsRogueModel.Instance;
		SurvivorsCombo? curComboConfig = instance.CurComboConfig;
		if (curComboConfig == null)
		{
			return;
		}
		int[] comboNumArray = curComboConfig.Value.GetComboNumArray();
		int[] comboDurationArray = curComboConfig.Value.GetComboDurationArray();
		if (comboDurationArray.Length != comboNumArray.Length || comboNumArray.Length != 4)
		{
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.SurvivorsRogue;
			ELogAuthor author = ELogAuthor.CK;
			string message = "幸存者连杀等级配置数量不匹配";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("连杀阈值配置数量", comboNumArray.Length);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("连杀时间配置数量", comboDurationArray.Length);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("合法数量", 4);
			instance2.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return;
		}
		int[] comboTimerFreezeTimeCfg = instance.ComboTimerFreezeTimeCfg;
		int num = 3;
		for (int i = 0; i < num; i++)
		{
			if (comboNum >= comboNumArray[i] && comboNum < comboNumArray[i + 1])
			{
				this.ApplyComboDuration(i, (float)comboDurationArray[i], (float)instance.ComboDurationAdditionCfg[i], (float)comboTimerFreezeTimeCfg[i]);
				return;
			}
		}
		this.ApplyComboDuration(num, (float)comboDurationArray[num], (float)instance.ComboDurationAdditionCfg[num], (float)comboTimerFreezeTimeCfg[num]);
	}

	// Token: 0x0600E178 RID: 57720 RVA: 0x0034EECC File Offset: 0x0034D0CC
	private unsafe void ApplyComboDuration(int level, float baseDuration, float extraDuration, float freezeTime)
	{
		this.ComboAnimHandle[level]();
		this.ComboDurationTimeInternal = (baseDuration + extraDuration) * (float)TimeUtil.Instance.InverseMillisecond;
		if (this.LastComboLevelIndex != level)
		{
			this.LastComboLevelIndex = level;
			this.FreezeTime += freezeTime * (float)TimeUtil.Instance.InverseMillisecond;
		}
		this.RemainTime = this.ComboDurationTimeInternal;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.SurvivorsRogue;
		ELogAuthor author = ELogAuthor.CK;
		string message = "幸存者连杀时间刷新";
		<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("基础时间", baseDuration);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("额外时间", extraDuration);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("冻结时间", freezeTime);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("剩余时间", this.RemainTime);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("最大时间", this.ComboDurationTime);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("连杀进度条百分比", this.RemainTime / this.ComboDurationTime);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
	}

	// Token: 0x0600E179 RID: 57721 RVA: 0x0034F024 File Offset: 0x0034D224
	public void RefreshCurrencyNum(int currencyNum, bool playSequence = true)
	{
		bool efficiencyEnhance = SurvivorsRogueModel.Instance.BattleData.GetGoldGainEfficiency() > 0;
		this.CurrencyCollectionItem.Refresh(currencyNum, efficiencyEnhance, playSequence);
	}

	// Token: 0x0600E17A RID: 57722 RVA: 0x0034F052 File Offset: 0x0034D252
	public void RefreshChestNum(int chestNum, bool playSequence = true)
	{
		this.ChestCollectionItem.Refresh(chestNum, false, playSequence);
	}

	// Token: 0x0600E17B RID: 57723 RVA: 0x0034F064 File Offset: 0x0034D264
	public void SetChestActive(bool active)
	{
		this.ChestCollectionItem.SetUiActive(active);
		this.ComboPlayer.StopPlayingSequence(false, true);
		this.ComboPlayer.PlayOrReplaySequenceByName("Start", false, null);
	}

	// Token: 0x0600E17C RID: 57724 RVA: 0x0034F0A4 File Offset: 0x0034D2A4
	public unsafe void SetComboAreaActive(bool active, bool playSequence = true)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.SurvivorsRogue;
		ELogAuthor author = ELogAuthor.CK;
		string message = "SetComboAreaActive";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Active", active);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PlaySequence", playSequence);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		this.ComboPlayer.StopPlayingSequence(false, true);
		if (active)
		{
			this.ComboArea.SetUIActive(true);
			if (playSequence)
			{
				this.ComboPlayer.PlayOrReplaySequenceByName("Start", false, null);
				return;
			}
		}
		else
		{
			if (playSequence)
			{
				this.ComboPlayer.StopPlayingSequence(false, true);
				this.ComboPlayer.PlayOrReplaySequenceByName("Close", false, null);
				return;
			}
			this.ComboArea.SetUIActive(false);
		}
	}

	// Token: 0x0600E17D RID: 57725 RVA: 0x0034F184 File Offset: 0x0034D384
	public unsafe void SetPositiveAreaActive(bool active, bool playSequence = true)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.SurvivorsRogue;
		ELogAuthor author = ELogAuthor.CK;
		string message = "SetPositiveAreaActive";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Active", active);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PlaySequence", playSequence);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		this.PositiveAreaPlayer.StopPlayingSequence(false, true);
		if (active)
		{
			this.PositiveArea.SetUIActive(true);
			this.PositiveIcon.SetUIActive(true);
			this.PositiveArrow.SetUIActive(true);
			this.PositiveAreaPlayer.PlayOrReplaySequenceByName("Start", false, null);
		}
		else if (playSequence)
		{
			this.PositiveAreaPlayer.PlayOrReplaySequenceByName("Close", false, null);
		}
		else
		{
			this.PositiveArea.SetUIActive(false);
		}
		EventSystem.Instance.Emit<bool>(EEventName.SurvivorsRogueComboBuffShow, active);
	}

	// Token: 0x0600E17E RID: 57726 RVA: 0x0034F280 File Offset: 0x0034D480
	public void RefreshPositiveArea(int value)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.SurvivorsRogue;
		ELogAuthor author = ELogAuthor.CK;
		string message = "RefreshPositiveArea";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Value", value);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		bool flag = value > 0;
		LguiUtil.Instance.SetLocalTextNew(this.PositiveText, "SurvivorsCombat_IncomeBuff", new <>z__ReadOnlySingleElementList<object>((int)Math.Ceiling((double)((float)value / 100f))));
		this.SetPositiveAreaActive(flag, this.CurPositiveEffectActive != flag);
		this.CurPositiveEffectActive = flag;
	}

	// Token: 0x0600E17F RID: 57727 RVA: 0x0034F309 File Offset: 0x0034D509
	private void SetComboRemainTimeBarPercent(float percent)
	{
		if (this.ComboRemainTimeBarSprite.bIsUIActive)
		{
			this.ComboRemainTimeBarSprite.SetFillAmount(percent);
		}
	}

	// Token: 0x0400682F RID: 26671
	private const int DEFAULT_COMBO_DURATION_TIME = 5000;

	// Token: 0x04006830 RID: 26672
	private SurvivorsRogueCollectionItem CurrencyCollectionItem;

	// Token: 0x04006831 RID: 26673
	private LevelSequencePlayer CurrencyEfficiencyEnhancePlayer;

	// Token: 0x04006832 RID: 26674
	private SurvivorsRogueCollectionItem ChestCollectionItem;

	// Token: 0x04006833 RID: 26675
	private UUIItem ComboArea;

	// Token: 0x04006834 RID: 26676
	private LevelSequencePlayer ComboPlayer;

	// Token: 0x04006835 RID: 26677
	private UUIItem PositiveArea;

	// Token: 0x04006836 RID: 26678
	private LevelSequencePlayer PositiveAreaPlayer;

	// Token: 0x04006837 RID: 26679
	private UUIArtText ComboNumText;

	// Token: 0x04006838 RID: 26680
	private UUISprite ComboRemainTimeBarSprite;

	// Token: 0x04006839 RID: 26681
	private UUITexture PositiveIcon;

	// Token: 0x0400683A RID: 26682
	private UUIText PositiveText;

	// Token: 0x0400683B RID: 26683
	private UUISprite PositiveArrow;

	// Token: 0x0400683C RID: 26684
	private float ComboDurationTimeInternal;

	// Token: 0x0400683D RID: 26685
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<Action> ComboAnimHandle;

	// Token: 0x0400683E RID: 26686
	private float RemainTime;

	// Token: 0x0400683F RID: 26687
	private float FreezeTime;

	// Token: 0x04006840 RID: 26688
	private int LastComboLevelIndex;

	// Token: 0x04006841 RID: 26689
	private bool NeedTick;

	// Token: 0x04006842 RID: 26690
	private bool TickEnabled;

	// Token: 0x04006843 RID: 26691
	private int CurComboNum;

	// Token: 0x04006844 RID: 26692
	private bool CurPositiveEffectActive;

	// Token: 0x02008315 RID: 33557
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402AC08 RID: 175112
		public const int QuitButton = 0;

		// Token: 0x0402AC09 RID: 175113
		public const int CurrencyItem = 1;

		// Token: 0x0402AC0A RID: 175114
		public const int ChestItem = 2;

		// Token: 0x0402AC0B RID: 175115
		public const int ComboRemainTimeBar = 3;

		// Token: 0x0402AC0C RID: 175116
		public const int ComboNum = 4;

		// Token: 0x0402AC0D RID: 175117
		public const int PositiveIcon = 5;

		// Token: 0x0402AC0E RID: 175118
		public const int PositiveText = 6;

		// Token: 0x0402AC0F RID: 175119
		public const int PositiveTip = 7;

		// Token: 0x0402AC10 RID: 175120
		public const int SettingButton = 8;

		// Token: 0x0402AC11 RID: 175121
		public const int ComboArea = 9;

		// Token: 0x0402AC12 RID: 175122
		public const int PositiveArea = 10;
	}
}
