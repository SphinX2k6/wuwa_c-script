using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Kurotato;
using CSharpScript.Game.Module.Kurotato.Data;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001CBB RID: 7355
[NullableContext(1)]
[Nullable(0)]
public class KurotatoFightInfoPanel : UiPanelBase
{
	// Token: 0x17001204 RID: 4612
	// (get) Token: 0x0600DE37 RID: 56887 RVA: 0x0033F3DE File Offset: 0x0033D5DE
	private float ComboDurationTime
	{
		get
		{
			if (this.ComboDurationTimeInternal != 0f)
			{
				return this.ComboDurationTimeInternal;
			}
			return 5000f;
		}
	}

	// Token: 0x0600DE38 RID: 56888 RVA: 0x0033F3FC File Offset: 0x0033D5FC
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
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(13, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnQuitButtonClicked)),
			new ValueTuple<int, Delegate>(8, new Action(this.OnSettingButtonClicked)),
			new ValueTuple<int, Delegate>(12, new Action(this.OnBtnInfoClicked)),
			new ValueTuple<int, Delegate>(13, new Action(this.OnBtnMonsterClicked))
		};
	}

	// Token: 0x0600DE39 RID: 56889 RVA: 0x0033F5BA File Offset: 0x0033D7BA
	private void OnQuitButtonClicked()
	{
		KurotatoController.Instance.LeaveInstanceDungeon();
	}

	// Token: 0x0600DE3A RID: 56890 RVA: 0x0033F5C6 File Offset: 0x0033D7C6
	private void OnSettingButtonClicked()
	{
		UiManager.Instance.OpenView(EUiViewName.MenuView, null, null);
	}

	// Token: 0x0600DE3B RID: 56891 RVA: 0x0033F5D9 File Offset: 0x0033D7D9
	private void OnBtnInfoClicked()
	{
		UiManager.Instance.OpenView(EUiViewName.KurotatoTabMainView, null, null);
	}

	// Token: 0x0600DE3C RID: 56892 RVA: 0x0033F5EC File Offset: 0x0033D7EC
	private void OnBtnMonsterClicked()
	{
	}

	// Token: 0x0600DE3D RID: 56893 RVA: 0x0033F5F0 File Offset: 0x0033D7F0
	protected override UniTask OnBeforeStartAsync()
	{
		KurotatoFightInfoPanel.<OnBeforeStartAsync>d__30 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoFightInfoPanel.<OnBeforeStartAsync>d__30>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DE3E RID: 56894 RVA: 0x0033F634 File Offset: 0x0033D834
	protected unsafe override void OnStart()
	{
		base.GetButton(12).RootUIComp.Get().SetUIActive(true);
		base.GetButton(13).RootUIComp.Get().SetUIActive(true);
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
			ELogModule module = ELogModule.Kurotato;
			ELogAuthor author = ELogAuthor.LYX;
			string message = "连杀等级配置数量不匹配";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("合法数量", 4);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("实际数量", this.ComboAnimHandle.Count);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		this.ComboArea.SetUIActive(false);
		this.PositiveArea.SetUIActive(false);
		this.CurrencyCollectionItem.SetUiActive(true);
		this.ChestCollectionItem.SetUiActive(true);
	}

	// Token: 0x0600DE3F RID: 56895 RVA: 0x0033F850 File Offset: 0x0033DA50
	protected override void OnBeforeShow()
	{
		KurotatoBattleData battleData = KurotatoModel.Instance.BattleData;
		this.RefreshCurrencyNum(battleData.GetCurrencyCount(), false);
		this.RefreshSpareGold(battleData.GetSpareGold(), false);
		this.TickEnabled = true;
	}

	// Token: 0x0600DE40 RID: 56896 RVA: 0x0033F889 File Offset: 0x0033DA89
	protected override void OnBeforeHide()
	{
		this.TickEnabled = false;
	}

	// Token: 0x0600DE41 RID: 56897 RVA: 0x0033F894 File Offset: 0x0033DA94
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
			ELogModule module = ELogModule.Kurotato;
			ELogAuthor author = ELogAuthor.LYX;
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
		ELogModule module2 = ELogModule.Kurotato;
		ELogAuthor author2 = ELogAuthor.LYX;
		string message2 = "连杀时间进度更新";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("RemainTime", this.RemainTime);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ComboDurationTime", this.ComboDurationTime);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Percent", this.RemainTime / this.ComboDurationTime);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		this.SetComboRemainTimeBarPercent(this.RemainTime / this.ComboDurationTime);
	}

	// Token: 0x0600DE42 RID: 56898 RVA: 0x0033F9D6 File Offset: 0x0033DBD6
	public void ResetFightInfo()
	{
		this.RefreshComboNum(0);
		this.RefreshPositiveArea(0);
	}

	// Token: 0x0600DE43 RID: 56899 RVA: 0x0033F9E8 File Offset: 0x0033DBE8
	public void RefreshComboNum(int comboNum)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Kurotato;
		ELogAuthor author = ELogAuthor.LYX;
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
			return;
		}
		this.ComboNumText.SetText(comboNum.ToString());
		this.SetComboRemainTimeBarPercent(1f);
		this.SetComboAreaActive(true, this.CurComboNum == 0);
		this.NeedTick = true;
		this.CurComboNum = comboNum;
	}

	// Token: 0x0600DE44 RID: 56900 RVA: 0x0033FAA4 File Offset: 0x0033DCA4
	public void RefreshCurrencyNum(int currencyNum, bool playSequence = true)
	{
		bool efficiencyEnhance = KurotatoModel.Instance.BattleData.GetGoldGainEfficiency() > 0;
		this.CurrencyCollectionItem.Refresh(currencyNum, efficiencyEnhance, playSequence);
	}

	// Token: 0x0600DE45 RID: 56901 RVA: 0x0033FAD2 File Offset: 0x0033DCD2
	public void RefreshSpareGold(int spareGold, bool playSequence = true)
	{
		this.ChestCollectionItem.Refresh(spareGold, false, playSequence);
	}

	// Token: 0x0600DE46 RID: 56902 RVA: 0x0033FAE2 File Offset: 0x0033DCE2
	public void RefreshChestNum(int chestNum, bool playSequence = true)
	{
	}

	// Token: 0x0600DE47 RID: 56903 RVA: 0x0033FAE4 File Offset: 0x0033DCE4
	public void SetChestActive(bool active)
	{
		this.ChestCollectionItem.SetUiActive(active);
		this.ComboPlayer.StopPlayingSequence(false, true);
		this.ComboPlayer.PlayOrReplaySequenceByName("Start", false, null);
	}

	// Token: 0x0600DE48 RID: 56904 RVA: 0x0033FB24 File Offset: 0x0033DD24
	public unsafe void SetComboAreaActive(bool active, bool playSequence = true)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Kurotato;
		ELogAuthor author = ELogAuthor.LYX;
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

	// Token: 0x0600DE49 RID: 56905 RVA: 0x0033FC04 File Offset: 0x0033DE04
	public unsafe void SetPositiveAreaActive(bool active, bool playSequence = true)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Kurotato;
		ELogAuthor author = ELogAuthor.LYX;
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

	// Token: 0x0600DE4A RID: 56906 RVA: 0x0033FD00 File Offset: 0x0033DF00
	public void RefreshPositiveArea(int value)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Kurotato;
		ELogAuthor author = ELogAuthor.LYX;
		string message = "RefreshPositiveArea";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Value", value);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		bool flag = value > 0;
		LguiUtil.Instance.SetLocalTextNew(this.PositiveText, "SurvivorsCombat_IncomeBuff", new <>z__ReadOnlySingleElementList<object>((int)Math.Ceiling((double)((float)value / 100f))));
		this.SetPositiveAreaActive(flag, this.CurPositiveEffectActive != flag);
		this.CurPositiveEffectActive = flag;
	}

	// Token: 0x0600DE4B RID: 56907 RVA: 0x0033FD89 File Offset: 0x0033DF89
	private void SetComboRemainTimeBarPercent(float percent)
	{
		if (this.ComboRemainTimeBarSprite.bIsUIActive)
		{
			this.ComboRemainTimeBarSprite.SetFillAmount(percent);
		}
	}

	// Token: 0x040065FE RID: 26110
	private const int DEFAULT_COMBO_DURATION_TIME = 5000;

	// Token: 0x040065FF RID: 26111
	private readonly SurvivorsRogueCollectionItem CurrencyCollectionItem = new SurvivorsRogueCollectionItem();

	// Token: 0x04006600 RID: 26112
	private LevelSequencePlayer CurrencyEfficiencyEnhancePlayer;

	// Token: 0x04006601 RID: 26113
	private readonly SurvivorsRogueCollectionItem ChestCollectionItem = new SurvivorsRogueCollectionItem();

	// Token: 0x04006602 RID: 26114
	private UUIItem ComboArea;

	// Token: 0x04006603 RID: 26115
	private LevelSequencePlayer ComboPlayer;

	// Token: 0x04006604 RID: 26116
	private UUIItem PositiveArea;

	// Token: 0x04006605 RID: 26117
	private LevelSequencePlayer PositiveAreaPlayer;

	// Token: 0x04006606 RID: 26118
	private UUIArtText ComboNumText;

	// Token: 0x04006607 RID: 26119
	private UUISprite ComboRemainTimeBarSprite;

	// Token: 0x04006608 RID: 26120
	private UUITexture PositiveIcon;

	// Token: 0x04006609 RID: 26121
	private UUIText PositiveText;

	// Token: 0x0400660A RID: 26122
	private UUISprite PositiveArrow;

	// Token: 0x0400660B RID: 26123
	private readonly float ComboDurationTimeInternal;

	// Token: 0x0400660C RID: 26124
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<Action> ComboAnimHandle;

	// Token: 0x0400660D RID: 26125
	private float RemainTime;

	// Token: 0x0400660E RID: 26126
	private float FreezeTime;

	// Token: 0x0400660F RID: 26127
	protected int LastComboLevelIndex;

	// Token: 0x04006610 RID: 26128
	private bool NeedTick;

	// Token: 0x04006611 RID: 26129
	private bool TickEnabled;

	// Token: 0x04006612 RID: 26130
	private int CurComboNum;

	// Token: 0x04006613 RID: 26131
	private bool CurPositiveEffectActive;

	// Token: 0x020082A3 RID: 33443
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402A9CE RID: 174542
		public const int QuitButton = 0;

		// Token: 0x0402A9CF RID: 174543
		public const int CurrencyItem = 1;

		// Token: 0x0402A9D0 RID: 174544
		public const int ChestItem = 2;

		// Token: 0x0402A9D1 RID: 174545
		public const int ComboRemainTimeBar = 3;

		// Token: 0x0402A9D2 RID: 174546
		public const int ComboNum = 4;

		// Token: 0x0402A9D3 RID: 174547
		public const int PositiveIcon = 5;

		// Token: 0x0402A9D4 RID: 174548
		public const int PositiveText = 6;

		// Token: 0x0402A9D5 RID: 174549
		public const int PositiveTip = 7;

		// Token: 0x0402A9D6 RID: 174550
		public const int SettingButton = 8;

		// Token: 0x0402A9D7 RID: 174551
		public const int ComboArea = 9;

		// Token: 0x0402A9D8 RID: 174552
		public const int PositiveArea = 10;

		// Token: 0x0402A9D9 RID: 174553
		public const int PanelBox = 11;

		// Token: 0x0402A9DA RID: 174554
		public const int BtnInfo = 12;

		// Token: 0x0402A9DB RID: 174555
		public const int BtnMonster = 13;
	}
}
