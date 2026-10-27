using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RacingBets;
using CSharpScript.Game.Module.RacingBets.Data;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002727 RID: 10023
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsBettingView : UiTickViewBase, IUiCameraBehavior
{
	// Token: 0x060148AF RID: 84143 RVA: 0x005307E4 File Offset: 0x0052E9E4
	public RacingBetsBettingView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060148B0 RID: 84144 RVA: 0x00530818 File Offset: 0x0052EA18
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(8, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(12, typeof(UUITexture)),
			new ValueTuple<int, Type>(13, typeof(UUIText)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUIItem)),
			new ValueTuple<int, Type>(17, typeof(UUIText)),
			new ValueTuple<int, Type>(18, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(19, typeof(UUIText)),
			new ValueTuple<int, Type>(20, typeof(UUIText)),
			new ValueTuple<int, Type>(21, typeof(UUIText)),
			new ValueTuple<int, Type>(22, typeof(UUIText)),
			new ValueTuple<int, Type>(23, typeof(UUIText)),
			new ValueTuple<int, Type>(24, typeof(UUIText)),
			new ValueTuple<int, Type>(25, typeof(UUIItem)),
			new ValueTuple<int, Type>(26, typeof(UUIItem)),
			new ValueTuple<int, Type>(27, typeof(UUIItem)),
			new ValueTuple<int, Type>(28, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(7, new Action(this.OnClickCloseButton)),
			new ValueTuple<int, Delegate>(11, new Action(this.OnClickBetsButton)),
			new ValueTuple<int, Delegate>(18, new Action(this.OnClickCancelBetsButton))
		};
	}

	// Token: 0x060148B1 RID: 84145 RVA: 0x00530B18 File Offset: 0x0052ED18
	protected override UniTask OnBeforeStartAsync()
	{
		RacingBetsBettingView.<OnBeforeStartAsync>d__18 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RacingBetsBettingView.<OnBeforeStartAsync>d__18>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060148B2 RID: 84146 RVA: 0x00530B5C File Offset: 0x0052ED5C
	private UniTask InitComponents()
	{
		RacingBetsBettingView.<InitComponents>d__19 <InitComponents>d__;
		<InitComponents>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitComponents>d__.<>4__this = this;
		<InitComponents>d__.<>1__state = -1;
		<InitComponents>d__.<>t__builder.Start<RacingBetsBettingView.<InitComponents>d__19>(ref <InitComponents>d__);
		return <InitComponents>d__.<>t__builder.Task;
	}

	// Token: 0x060148B3 RID: 84147 RVA: 0x00530B9F File Offset: 0x0052ED9F
	public void PushCameraHandle(EUiViewName viewName, int viewId, bool isBlend)
	{
		UiCameraAnimationController.Instance.PushCameraHandle((EUiViewName)this.CurSelectDango.DangoCamera, new int?(viewId), isBlend);
	}

	// Token: 0x060148B4 RID: 84148 RVA: 0x00530BC4 File Offset: 0x0052EDC4
	protected override void OnBeforeShow()
	{
		int num = this.DangoActorDataList.FindIndex((IRacingBetsDangoActorData data) => data == this.CurSelectDango);
		this.DangoLayout.SelectGridProxy(num, false);
		this.CurSelectDangoActor = this.DangoActorList[num];
		this.FadeAllDangoActor(this.DangoActorList, num, true);
		this.RefreshUi(this.LegMatchData, this.CurSelectDango, this.CurSelectGearConfig.Value);
		this.RefreshCurrencyItem();
		RacingBetsSeasonData racingBetsSeasonData = RacingBetsModel.Instance.GetRacingBetsSeasonData();
		RacingBetsController.Instance.TryRegisterNextDangoOddsUpdateRequest(racingBetsSeasonData);
		RacingBetsController.Instance.RacingBetsUpdateOddsRequest(0f);
	}

	// Token: 0x060148B5 RID: 84149 RVA: 0x00530C5E File Offset: 0x0052EE5E
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnRacingBetsPlayerInfoUpdate, new Action(this.OnRacingBetsPlayerInfoUpdate));
		EventSystem.Instance.Add<int, bool>(EEventName.OnRacingBetsBettingInfoUpdate, new Action<int, bool>(this.OnRacingBetsBettingInfoUpdate));
	}

	// Token: 0x060148B6 RID: 84150 RVA: 0x00530C98 File Offset: 0x0052EE98
	protected override void OnTick(float delta)
	{
		if (!this.Tickable)
		{
			return;
		}
		if (this.LegMatchData.GetLegMatchState() == ERacingBetsLegMatchState.BettingPeriod)
		{
			this.RefreshOddsTimeText(this.LegMatchData);
			this.RefreshBetRemindTimeText();
			return;
		}
		this.Tickable = false;
		this.ShowCloseConfirmBox();
	}

	// Token: 0x060148B7 RID: 84151 RVA: 0x00530CD4 File Offset: 0x0052EED4
	private void RefreshUi(RacingBetsLegMatchData legMatchData, IRacingBetsDangoActorData dangoActorData, RacingBettingGear gearConfig)
	{
		if (dangoActorData.IsAbuDango)
		{
			base.GetItem(26).SetUIActive(false);
			base.GetItem(27).SetUIActive(true);
		}
		else
		{
			base.GetItem(26).SetUIActive(true);
			base.GetItem(27).SetUIActive(false);
			if (legMatchData.HasBetting)
			{
				this.RefreshBetsResultPanel(legMatchData, dangoActorData);
				base.GetItem(5).SetUIActive(true);
				base.GetItem(4).SetUIActive(false);
			}
			else
			{
				this.RefreshBetsPanel(legMatchData, dangoActorData, gearConfig);
				base.GetItem(4).SetUIActive(true);
				base.GetItem(5).SetUIActive(false);
			}
		}
		DangoData dangoData = DangoManager.Instance.GetDangoData(dangoActorData.DangoId);
		base.GetText(0).ShowTextNew(dangoData.NameKey);
		DangoSkill? dangoSkill;
		base.GetText(1).ShowTextNew(((dangoData.GetSkillConfig() != null) ? dangoSkill.GetValueOrDefault().Desc : null) ?? "");
		base.GetText(3).ShowTextNew(legMatchData.Name);
		base.GetItem(16).SetUIActive(false);
		this.RefreshOddsTimeText(legMatchData);
		foreach (RacingBetsDangoOddsItem racingBetsDangoOddsItem in this.DangoLayout.GetLayoutItemList())
		{
			racingBetsDangoOddsItem.RefreshOddsDango(legMatchData.BetDangoId);
		}
		base.GetText(22).ShowTextNew("Dango_MainPage_StatusTime_Bet");
		this.RefreshBetRemindTimeText();
	}

	// Token: 0x060148B8 RID: 84152 RVA: 0x00530E5C File Offset: 0x0052F05C
	private void RefreshBetsPanel(RacingBetsLegMatchData legMatchData, IRacingBetsDangoActorData oddsData, RacingBettingGear gearConfig)
	{
		RacingBetsSeasonData racingBetsSeasonData = RacingBetsModel.Instance.GetRacingBetsSeasonData();
		int currencyItemId = racingBetsSeasonData.GetCurrencyItemId();
		int betCostCount = racingBetsSeasonData.GetBetCostCount(gearConfig);
		this.BetsCostItem.RefreshUi(currencyItemId, betCostCount);
		int count = (int)Math.Ceiling((double)(betCostCount * oddsData.Odds) / 100.0);
		this.BetsRewardItem.RefreshUi(currencyItemId, count);
		UUIText text = base.GetText(24);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendLiteral("×");
		defaultInterpolatedStringHandler.AppendFormatted<int>(oddsData.Odds / 100);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
	}

	// Token: 0x060148B9 RID: 84153 RVA: 0x00530EF0 File Offset: 0x0052F0F0
	private void RefreshBetsResultPanel(RacingBetsLegMatchData legMatchData, IRacingBetsDangoActorData oddsData)
	{
		int currencyItemId = RacingBetsModel.Instance.GetRacingBetsSeasonData().GetCurrencyItemId();
		DangoData dangoData = DangoManager.Instance.GetDangoData(legMatchData.BetDangoId);
		base.SetTextureShowUntilLoaded(dangoData.Icon, base.GetTexture(12), null);
		base.GetText(13).ShowTextNew(dangoData.NameKey);
		this.BetsResultCostItem.RefreshUi(currencyItemId, legMatchData.BetGearCash);
		this.BetsResultRewardItem.RefreshUi(currencyItemId, legMatchData.GetOddsRewardCount());
		base.GetText(17).SetText(legMatchData.LeaveCancelNum.ToString(), true);
		base.GetButton(18).RootUIComp.Get().SetUIActive(legMatchData.LeaveCancelNum > 0);
		UUIText text = base.GetText(23);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendLiteral("×");
		defaultInterpolatedStringHandler.AppendFormatted<int>(legMatchData.Odds / 100);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
	}

	// Token: 0x060148BA RID: 84154 RVA: 0x00530FE4 File Offset: 0x0052F1E4
	private void RefreshOddsTimeText(RacingBetsLegMatchData legMatchData)
	{
		if (legMatchData.IsFinalOddsRefresh)
		{
			base.GetItem(25).SetUIActive(false);
			return;
		}
		base.GetItem(25).SetUIActive(true);
		base.GetText(19).ShowTextNew("Dango_BetPage_Function_NextBetRate");
		string newText = TimeUtil.Instance.DateFormat7String(this.LegMatchData.NextOddsRateRefreshTime);
		base.GetText(20).SetText(newText, true);
	}

	// Token: 0x060148BB RID: 84155 RVA: 0x00531050 File Offset: 0x0052F250
	private void RefreshBetRemindTimeText()
	{
		double serverTime = TimeUtil.Instance.GetServerTime();
		CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat3(this.LegMatchData.BetsEndTime * TimeUtil.Instance.Millisecond - serverTime);
		if (remainTimeDataFormat != null && remainTimeDataFormat.CountDownText != null)
		{
			base.GetText(21).SetText(remainTimeDataFormat.CountDownText, true);
		}
	}

	// Token: 0x060148BC RID: 84156 RVA: 0x005310AC File Offset: 0x0052F2AC
	private void RefreshCurrencyItem()
	{
		RacingBetsSeasonData racingBetsSeasonData = RacingBetsModel.Instance.GetRacingBetsSeasonData();
		this.CommonCurrencyItem.RefreshTemp(racingBetsSeasonData.GetCurrencyItemId(), racingBetsSeasonData.GetCurrencyCount().ToString());
		this.CommonCurrencyItem.SetButtonActive(false);
	}

	// Token: 0x060148BD RID: 84157 RVA: 0x005310EF File Offset: 0x0052F2EF
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnRacingBetsPlayerInfoUpdate, new Action(this.OnRacingBetsPlayerInfoUpdate));
		EventSystem.Instance.Remove(EEventName.OnRacingBetsBettingInfoUpdate, new Action<int, bool>(this.OnRacingBetsBettingInfoUpdate));
	}

	// Token: 0x060148BE RID: 84158 RVA: 0x0053112C File Offset: 0x0052F32C
	protected override void OnBeforeHide()
	{
		int exceptIndex = this.DangoActorDataList.FindIndex((IRacingBetsDangoActorData data) => data == this.CurSelectDango);
		this.FadeAllDangoActor(this.DangoActorList, exceptIndex, false);
	}

	// Token: 0x060148BF RID: 84159 RVA: 0x0053115F File Offset: 0x0052F35F
	[NullableContext(2)]
	public void PopCameraHandle(EUiViewName viewName, UiViewInfo stackTopInfo, int closeViewId, bool popOrDelete)
	{
		UiCameraAnimationController.Instance.PopCameraHandle((EUiViewName)this.CurSelectDango.DangoCamera, stackTopInfo, closeViewId, popOrDelete);
	}

	// Token: 0x060148C0 RID: 84160 RVA: 0x00531180 File Offset: 0x0052F380
	private void SelectDangoActor(TsUiSceneDangoActor dangoActor)
	{
		if (this.CurSelectDangoActor == dangoActor)
		{
			return;
		}
		if (this.CurSelectDangoActor != null)
		{
			TsUiSceneDangoActor selectActor = this.CurSelectDangoActor;
			UiModelUtil.Instance.DangoFadeIn(this.CurSelectDangoActor, new ERoleFadeCurveDefine?(ERoleFadeCurveDefine.RoleFadeInCurve), delegate
			{
				if (selectActor.Model != null)
				{
					UiModelUtil.Instance.SetVisible(selectActor.Model, false);
				}
			});
		}
		this.CurSelectDangoActor = dangoActor;
		if (this.CurSelectDangoActor.Model != null)
		{
			UiModelUtil.Instance.SetVisible(this.CurSelectDangoActor.Model, true);
			UiModelUtil.Instance.DangoFadeOut(this.CurSelectDangoActor, null, null);
		}
	}

	// Token: 0x060148C1 RID: 84161 RVA: 0x0053121C File Offset: 0x0052F41C
	private void FadeAllDangoActor(List<TsUiSceneDangoActor> dangoActorList, int exceptIndex, bool isFadeIn)
	{
		int index;
		Action <>9__0;
		int index2;
		for (index = 0; index < dangoActorList.Count; index = index2 + 1)
		{
			if (index != exceptIndex)
			{
				if (isFadeIn)
				{
					UiModelUtil instance = UiModelUtil.Instance;
					TsUiSceneDangoActor actor = dangoActorList[index];
					ERoleFadeCurveDefine? curveId = new ERoleFadeCurveDefine?(ERoleFadeCurveDefine.RoleFadeInCurve);
					Action fadeFinishCallBack;
					if ((fadeFinishCallBack = <>9__0) == null)
					{
						fadeFinishCallBack = (<>9__0 = delegate()
						{
							if (dangoActorList[index].Model != null)
							{
								UiModelUtil.Instance.SetVisible(dangoActorList[index].Model, false);
							}
						});
					}
					instance.DangoFadeIn(actor, curveId, fadeFinishCallBack);
				}
				else if (dangoActorList[index].Model != null)
				{
					UiModelUtil.Instance.SetVisible(dangoActorList[index].Model, true);
					UiModelUtil.Instance.DangoFadeOut(dangoActorList[index], null, null);
				}
			}
			index2 = index;
		}
	}

	// Token: 0x060148C2 RID: 84162 RVA: 0x0053131C File Offset: 0x0052F51C
	private void ShowCloseConfirmBox()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RacingBetsBettingEndConfirm);
		confirmBoxDataNew.FunctionMap.Add(2, delegate
		{
			base.CloseMe(null);
		});
		confirmBoxDataNew.FunctionMap.Add(1, delegate
		{
			base.CloseMe(null);
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x060148C3 RID: 84163 RVA: 0x00531370 File Offset: 0x0052F570
	private RacingBetsGearItem BetsGearItemCreate()
	{
		RacingBetsGearItem racingBetsGearItem = new RacingBetsGearItem();
		racingBetsGearItem.BindClickGearItemCallBack(new Action<RacingBettingGear>(this.OnClickGearItem));
		return racingBetsGearItem;
	}

	// Token: 0x060148C4 RID: 84164 RVA: 0x00531389 File Offset: 0x0052F589
	private RacingBetsDangoOddsItem DangoItemCreate()
	{
		RacingBetsDangoOddsItem racingBetsDangoOddsItem = new RacingBetsDangoOddsItem();
		racingBetsDangoOddsItem.BindClickGearItemCallBack(new Action<IRacingBetsDangoActorData>(this.OnClickDangoItem));
		return racingBetsDangoOddsItem;
	}

	// Token: 0x060148C5 RID: 84165 RVA: 0x005313A4 File Offset: 0x0052F5A4
	private void OnClickGearItem(RacingBettingGear data)
	{
		this.CurSelectGearConfig = new RacingBettingGear?(data);
		int gridIndex = this.GearConfigList.ToList<RacingBettingGear>().FindIndex((RacingBettingGear value) => data.Id == value.Id);
		this.BetGearLayout.SelectGridProxy(gridIndex, false);
		this.RefreshBetsPanel(this.LegMatchData, this.CurSelectDango, this.CurSelectGearConfig.Value);
	}

	// Token: 0x060148C6 RID: 84166 RVA: 0x00531418 File Offset: 0x0052F618
	private void OnClickDangoItem(IRacingBetsDangoActorData data)
	{
		this.CurSelectDango = data2;
		int num = this.DangoActorDataList.FindIndex((IRacingBetsDangoActorData data) => data == this.CurSelectDango);
		this.DangoLayout.SelectGridProxy(num, false);
		this.RefreshUi(this.LegMatchData, data2, this.CurSelectGearConfig.Value);
		this.SelectDangoActor(this.DangoActorList[num]);
		UiCameraAnimationManager.Instance.PushCameraHandleByHandleName(this.CurSelectDango.DangoCamera, true, true, "1001", false, null, null);
	}

	// Token: 0x060148C7 RID: 84167 RVA: 0x005314A3 File Offset: 0x0052F6A3
	private void OnClickCloseButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x060148C8 RID: 84168 RVA: 0x005314AC File Offset: 0x0052F6AC
	private void OnClickBetsButton()
	{
		if (this.CurSelectDango.IsAbuDango)
		{
			Log.Instance.Warn(ELogModule.RacingBets, ELogAuthor.LRC, "阿布团子不能下注", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RacingBetsBettingConfirm);
		confirmBoxDataNew.FunctionMap.Add(2, delegate
		{
			RacingBetsSeasonData racingBetsSeasonData = RacingBetsModel.Instance.GetRacingBetsSeasonData();
			int betCostCount = racingBetsSeasonData.GetBetCostCount(this.CurSelectGearConfig.Value);
			RacingBetsController.Instance.RacingBetsGearRequest(racingBetsSeasonData.Id, this.LegMatchData, this.CurSelectDango.DangoId, this.CurSelectGearConfig.Value.Id, betCostCount);
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x060148C9 RID: 84169 RVA: 0x00531518 File Offset: 0x0052F718
	private void OnClickCancelBetsButton()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RacingBetsCancelBettingConfirm);
		confirmBoxDataNew.FunctionMap.Add(2, delegate
		{
			RacingBetsSeasonData racingBetsSeasonData = RacingBetsModel.Instance.GetRacingBetsSeasonData();
			RacingBetsController.Instance.RacingBetsGearRefundRequest(racingBetsSeasonData.Id, this.LegMatchData, this.LegMatchData.BetDangoId);
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x060148CA RID: 84170 RVA: 0x00531554 File Offset: 0x0052F754
	private void OnRacingBetsPlayerInfoUpdate()
	{
		this.RefreshUi(this.LegMatchData, this.CurSelectDango, this.CurSelectGearConfig.Value);
	}

	// Token: 0x060148CB RID: 84171 RVA: 0x00531574 File Offset: 0x0052F774
	private void OnRacingBetsBettingInfoUpdate(int dangoId, bool isBetting)
	{
		this.RefreshUi(this.LegMatchData, this.CurSelectDango, this.CurSelectGearConfig.Value);
		DangoData dangoData = DangoManager.Instance.GetDangoData(this.CurSelectDango.DangoId);
		if (isBetting)
		{
			TsUiSceneDangoActor curSelectDangoActor = this.CurSelectDangoActor;
			if (curSelectDangoActor != null)
			{
				curSelectDangoActor.SetState(EDangoState.ActionPerform, 1f, 0f);
			}
			AudioSystem.Instance.PostEvent(dangoData.DangoConfig.Value.CheerAudio);
			return;
		}
		if (dangoId == this.CurSelectDango.DangoId)
		{
			TsUiSceneDangoActor curSelectDangoActor2 = this.CurSelectDangoActor;
			if (curSelectDangoActor2 != null)
			{
				curSelectDangoActor2.SetState(EDangoState.ActionPerform, 4f, 0f);
			}
			AudioSystem.Instance.PostEvent(dangoData.DangoConfig.Value.DeathAudio);
		}
	}

	// Token: 0x04009A76 RID: 39542
	private bool Tickable = true;

	// Token: 0x04009A77 RID: 39543
	private IRacingBetsDangoActorData CurSelectDango;

	// Token: 0x04009A78 RID: 39544
	private RacingBettingGear? CurSelectGearConfig;

	// Token: 0x04009A79 RID: 39545
	[Nullable(2)]
	private TsUiSceneDangoActor CurSelectDangoActor;

	// Token: 0x04009A7A RID: 39546
	private RacingBetsLegMatchData LegMatchData;

	// Token: 0x04009A7B RID: 39547
	private List<IRacingBetsDangoActorData> DangoActorDataList = new List<IRacingBetsDangoActorData>();

	// Token: 0x04009A7C RID: 39548
	private List<TsUiSceneDangoActor> DangoActorList = new List<TsUiSceneDangoActor>();

	// Token: 0x04009A7D RID: 39549
	private IReadOnlyList<RacingBettingGear> GearConfigList = new List<RacingBettingGear>();

	// Token: 0x04009A7E RID: 39550
	private RacingBetsCostItem BetsCostItem;

	// Token: 0x04009A7F RID: 39551
	private RacingBetsCostItem BetsRewardItem;

	// Token: 0x04009A80 RID: 39552
	private RacingBetsCostItem BetsResultCostItem;

	// Token: 0x04009A81 RID: 39553
	private RacingBetsCostItem BetsResultRewardItem;

	// Token: 0x04009A82 RID: 39554
	private CommonCurrencyItem CommonCurrencyItem;

	// Token: 0x04009A83 RID: 39555
	private GenericLayout<RacingBetsGearItem, RacingBettingGear> BetGearLayout;

	// Token: 0x04009A84 RID: 39556
	private GenericLayout<RacingBetsDangoOddsItem, IRacingBetsDangoActorData> DangoLayout;

	// Token: 0x02008D81 RID: 36225
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x0402DEAF RID: 188079
		public const int DangoNameText = 0;

		// Token: 0x0402DEB0 RID: 188080
		public const int DangoSkillText = 1;

		// Token: 0x0402DEB1 RID: 188081
		public const int DangoLayout = 2;

		// Token: 0x0402DEB2 RID: 188082
		public const int LegMatchName = 3;

		// Token: 0x0402DEB3 RID: 188083
		public const int BetPanel = 4;

		// Token: 0x0402DEB4 RID: 188084
		public const int BetResultPanel = 5;

		// Token: 0x0402DEB5 RID: 188085
		public const int CurrencyItem = 6;

		// Token: 0x0402DEB6 RID: 188086
		public const int CloseButton = 7;

		// Token: 0x0402DEB7 RID: 188087
		public const int BetsGearLayout = 8;

		// Token: 0x0402DEB8 RID: 188088
		public const int BetsCostItem = 9;

		// Token: 0x0402DEB9 RID: 188089
		public const int BetsRewardItem = 10;

		// Token: 0x0402DEBA RID: 188090
		public const int BetsButton = 11;

		// Token: 0x0402DEBB RID: 188091
		public const int DangoTexture = 12;

		// Token: 0x0402DEBC RID: 188092
		public const int DangoName = 13;

		// Token: 0x0402DEBD RID: 188093
		public const int BetsResultCostItem = 14;

		// Token: 0x0402DEBE RID: 188094
		public const int BetsResultRewardItem = 15;

		// Token: 0x0402DEBF RID: 188095
		public const int RemainCancelItem = 16;

		// Token: 0x0402DEC0 RID: 188096
		public const int RemainCancelNumText = 17;

		// Token: 0x0402DEC1 RID: 188097
		public const int CancelButton = 18;

		// Token: 0x0402DEC2 RID: 188098
		public const int BetUpdateDescText = 19;

		// Token: 0x0402DEC3 RID: 188099
		public const int BetUpdateTimeText = 20;

		// Token: 0x0402DEC4 RID: 188100
		public const int TimeText = 21;

		// Token: 0x0402DEC5 RID: 188101
		public const int TimeDescText = 22;

		// Token: 0x0402DEC6 RID: 188102
		public const int BetOddsText = 23;

		// Token: 0x0402DEC7 RID: 188103
		public const int NotBetOddsText = 24;

		// Token: 0x0402DEC8 RID: 188104
		public const int OddsTimeItem = 25;

		// Token: 0x0402DEC9 RID: 188105
		public const int BetInfoPanel = 26;

		// Token: 0x0402DECA RID: 188106
		public const int AbuInfoPanel = 27;

		// Token: 0x0402DECB RID: 188107
		public const int AbuDescText = 28;
	}
}
