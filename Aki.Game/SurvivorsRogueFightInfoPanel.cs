using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020011DF RID: 4575
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueFightInfoPanel : UiPanelBase
{
	// Token: 0x17001242 RID: 4674
	// (get) Token: 0x0600B589 RID: 46473 RVA: 0x0035A1B0 File Offset: 0x003583B0
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

	// Token: 0x0600B58A RID: 46474 RVA: 0x0035A1CC File Offset: 0x003583CC
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

	// Token: 0x0600B58B RID: 46475 RVA: 0x0035A313 File Offset: 0x00358513
	private void OnQuitButtonClicked()
	{
		SurvivorsRogueController.Instance.OpenLeaveInstanceView();
	}

	// Token: 0x0600B58C RID: 46476 RVA: 0x0035A31F File Offset: 0x0035851F
	private void OnSettingButtonClicked()
	{
		UiManager.Instance.OpenView(EUiViewName.MenuView, null, null);
	}

	// Token: 0x0600B58D RID: 46477 RVA: 0x0035A334 File Offset: 0x00358534
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsRogueFightInfoPanel.<OnBeforeStartAsync>d__28 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsRogueFightInfoPanel.<OnBeforeStartAsync>d__28>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B58E RID: 46478 RVA: 0x0035A378 File Offset: 0x00358578
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

	// Token: 0x0600B58F RID: 46479 RVA: 0x0035A560 File Offset: 0x00358760
	protected override void OnBeforeShow()
	{
		SurvivorsRogueBattleData battleData = SurvivorsRogueModel.Instance.BattleData;
		this.RefreshCurrencyNum(battleData.GetCurrencyCount(), false);
		this.RefreshChestNum(battleData.GetChestCount(), false);
		this.TickEnabled = true;
	}

	// Token: 0x0600B590 RID: 46480 RVA: 0x0035A599 File Offset: 0x00358799
	protected override void OnBeforeHide()
	{
		this.TickEnabled = false;
	}

	// Token: 0x0600B591 RID: 46481 RVA: 0x0035A5A4 File Offset: 0x003587A4
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

	// Token: 0x0600B592 RID: 46482 RVA: 0x0035A6E6 File Offset: 0x003588E6
	public void ResetFightInfo()
	{
		this.RefreshComboNum(0);
		this.RefreshPositiveArea(0);
	}

	// Token: 0x0600B593 RID: 46483 RVA: 0x0035A6F8 File Offset: 0x003588F8
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

	// Token: 0x0600B594 RID: 46484 RVA: 0x0035A7BC File Offset: 0x003589BC
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

	// Token: 0x0600B595 RID: 46485 RVA: 0x0035A8FC File Offset: 0x00358AFC
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

	// Token: 0x0600B596 RID: 46486 RVA: 0x0035AA54 File Offset: 0x00358C54
	public void RefreshCurrencyNum(int currencyNum, bool playSequence = true)
	{
		bool efficiencyEnhance = SurvivorsRogueModel.Instance.BattleData.GetGoldGainEfficiency() > 0;
		this.CurrencyCollectionItem.Refresh(currencyNum, efficiencyEnhance, playSequence);
	}

	// Token: 0x0600B597 RID: 46487 RVA: 0x0035AA82 File Offset: 0x00358C82
	public void RefreshChestNum(int chestNum, bool playSequence = true)
	{
		this.ChestCollectionItem.Refresh(chestNum, false, playSequence);
	}

	// Token: 0x0600B598 RID: 46488 RVA: 0x0035AA94 File Offset: 0x00358C94
	public void SetChestActive(bool active)
	{
		this.ChestCollectionItem.SetUiActive(active);
		this.ComboPlayer.StopPlayingSequence(false, true);
		this.ComboPlayer.PlayOrReplaySequenceByName("Start", false, null);
	}

	// Token: 0x0600B599 RID: 46489 RVA: 0x0035AAD4 File Offset: 0x00358CD4
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

	// Token: 0x0600B59A RID: 46490 RVA: 0x0035ABB4 File Offset: 0x00358DB4
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

	// Token: 0x0600B59B RID: 46491 RVA: 0x0035ACB0 File Offset: 0x00358EB0
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

	// Token: 0x0600B59C RID: 46492 RVA: 0x0035AD39 File Offset: 0x00358F39
	private void SetComboRemainTimeBarPercent(float percent)
	{
		if (this.ComboRemainTimeBarSprite.bIsUIActive)
		{
			this.ComboRemainTimeBarSprite.SetFillAmount(percent);
		}
	}

	// Token: 0x0400690E RID: 26894
	private const int DEFAULT_COMBO_DURATION_TIME = 5000;

	// Token: 0x0400690F RID: 26895
	private SurvivorsRogueCollectionItem CurrencyCollectionItem;

	// Token: 0x04006910 RID: 26896
	private LevelSequencePlayer CurrencyEfficiencyEnhancePlayer;

	// Token: 0x04006911 RID: 26897
	private SurvivorsRogueCollectionItem ChestCollectionItem;

	// Token: 0x04006912 RID: 26898
	private UUIItem ComboArea;

	// Token: 0x04006913 RID: 26899
	private LevelSequencePlayer ComboPlayer;

	// Token: 0x04006914 RID: 26900
	private UUIItem PositiveArea;

	// Token: 0x04006915 RID: 26901
	private LevelSequencePlayer PositiveAreaPlayer;

	// Token: 0x04006916 RID: 26902
	private UUIArtText ComboNumText;

	// Token: 0x04006917 RID: 26903
	private UUISprite ComboRemainTimeBarSprite;

	// Token: 0x04006918 RID: 26904
	private UUITexture PositiveIcon;

	// Token: 0x04006919 RID: 26905
	private UUIText PositiveText;

	// Token: 0x0400691A RID: 26906
	private UUISprite PositiveArrow;

	// Token: 0x0400691B RID: 26907
	private float ComboDurationTimeInternal;

	// Token: 0x0400691C RID: 26908
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<Action> ComboAnimHandle;

	// Token: 0x0400691D RID: 26909
	private float RemainTime;

	// Token: 0x0400691E RID: 26910
	private float FreezeTime;

	// Token: 0x0400691F RID: 26911
	private int LastComboLevelIndex;

	// Token: 0x04006920 RID: 26912
	private bool NeedTick;

	// Token: 0x04006921 RID: 26913
	private bool TickEnabled;

	// Token: 0x04006922 RID: 26914
	private int CurComboNum;

	// Token: 0x04006923 RID: 26915
	private bool CurPositiveEffectActive;

	// Token: 0x0200749E RID: 29854
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04025F30 RID: 155440
		public const int QuitButton = 0;

		// Token: 0x04025F31 RID: 155441
		public const int CurrencyItem = 1;

		// Token: 0x04025F32 RID: 155442
		public const int ChestItem = 2;

		// Token: 0x04025F33 RID: 155443
		public const int ComboRemainTimeBar = 3;

		// Token: 0x04025F34 RID: 155444
		public const int ComboNum = 4;

		// Token: 0x04025F35 RID: 155445
		public const int PositiveIcon = 5;

		// Token: 0x04025F36 RID: 155446
		public const int PositiveText = 6;

		// Token: 0x04025F37 RID: 155447
		public const int PositiveTip = 7;

		// Token: 0x04025F38 RID: 155448
		public const int SettingButton = 8;

		// Token: 0x04025F39 RID: 155449
		public const int ComboArea = 9;

		// Token: 0x04025F3A RID: 155450
		public const int PositiveArea = 10;
	}
}
