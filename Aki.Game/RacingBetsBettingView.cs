using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RacingBets;
using CSharpScript.Game.Module.RacingBets.Data;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001C12 RID: 7186
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsBettingView : UiTickViewBase, IUiViewCameraBehavior
{
	// Token: 0x06011D91 RID: 73105 RVA: 0x0053F500 File Offset: 0x0053D700
	public RacingBetsBettingView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011D92 RID: 73106 RVA: 0x0053F534 File Offset: 0x0053D734
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

	// Token: 0x06011D93 RID: 73107 RVA: 0x0053F834 File Offset: 0x0053DA34
	protected override UniTask OnBeforeStartAsync()
	{
		RacingBetsBettingView.<OnBeforeStartAsync>d__18 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RacingBetsBettingView.<OnBeforeStartAsync>d__18>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011D94 RID: 73108 RVA: 0x0053F878 File Offset: 0x0053DA78
	private UniTask InitComponents()
	{
		RacingBetsBettingView.<InitComponents>d__19 <InitComponents>d__;
		<InitComponents>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitComponents>d__.<>4__this = this;
		<InitComponents>d__.<>1__state = -1;
		<InitComponents>d__.<>t__builder.Start<RacingBetsBettingView.<InitComponents>d__19>(ref <InitComponents>d__);
		return <InitComponents>d__.<>t__builder.Task;
	}

	// Token: 0x06011D95 RID: 73109 RVA: 0x0053F8BB File Offset: 0x0053DABB
	public void PushCameraHandleByOpenView(EUiViewName viewName, int viewId, EUiCameraHandleOperationType operationType)
	{
		UiCameraController.Instance.PushCameraHandleByOpenView((EUiViewName)this.CurSelectDango.DangoCamera, viewId, operationType);
	}

	// Token: 0x06011D96 RID: 73110 RVA: 0x0053F8DC File Offset: 0x0053DADC
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

	// Token: 0x06011D97 RID: 73111 RVA: 0x0053F976 File Offset: 0x0053DB76
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnRacingBetsPlayerInfoUpdate, new Action(this.OnRacingBetsPlayerInfoUpdate));
		EventSystem.Instance.Add<int, bool>(EEventName.OnRacingBetsBettingInfoUpdate, new Action<int, bool>(this.OnRacingBetsBettingInfoUpdate));
	}

	// Token: 0x06011D98 RID: 73112 RVA: 0x0053F9B0 File Offset: 0x0053DBB0
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

	// Token: 0x06011D99 RID: 73113 RVA: 0x0053F9EC File Offset: 0x0053DBEC
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

	// Token: 0x06011D9A RID: 73114 RVA: 0x0053FB74 File Offset: 0x0053DD74
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

	// Token: 0x06011D9B RID: 73115 RVA: 0x0053FC08 File Offset: 0x0053DE08
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

	// Token: 0x06011D9C RID: 73116 RVA: 0x0053FCFC File Offset: 0x0053DEFC
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

	// Token: 0x06011D9D RID: 73117 RVA: 0x0053FD68 File Offset: 0x0053DF68
	private void RefreshBetRemindTimeText()
	{
		double serverTime = TimeUtil.Instance.GetServerTime();
		CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat3(this.LegMatchData.BetsEndTime * TimeUtil.Instance.Millisecond - serverTime);
		if (remainTimeDataFormat != null && remainTimeDataFormat.CountDownText != null)
		{
			base.GetText(21).SetText(remainTimeDataFormat.CountDownText, true);
		}
	}

	// Token: 0x06011D9E RID: 73118 RVA: 0x0053FDC4 File Offset: 0x0053DFC4
	private void RefreshCurrencyItem()
	{
		RacingBetsSeasonData racingBetsSeasonData = RacingBetsModel.Instance.GetRacingBetsSeasonData();
		this.CommonCurrencyItem.RefreshTemp(racingBetsSeasonData.GetCurrencyItemId(), racingBetsSeasonData.GetCurrencyCount().ToString());
		this.CommonCurrencyItem.SetButtonActive(false);
	}

	// Token: 0x06011D9F RID: 73119 RVA: 0x0053FE07 File Offset: 0x0053E007
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnRacingBetsPlayerInfoUpdate, new Action(this.OnRacingBetsPlayerInfoUpdate));
		EventSystem.Instance.Remove(EEventName.OnRacingBetsBettingInfoUpdate, new Action<int, bool>(this.OnRacingBetsBettingInfoUpdate));
	}

	// Token: 0x06011DA0 RID: 73120 RVA: 0x0053FE44 File Offset: 0x0053E044
	protected override void OnBeforeHide()
	{
		int exceptIndex = this.DangoActorDataList.FindIndex((IRacingBetsDangoActorData data) => data == this.CurSelectDango);
		this.FadeAllDangoActor(this.DangoActorList, exceptIndex, false);
	}

	// Token: 0x06011DA1 RID: 73121 RVA: 0x0053FE77 File Offset: 0x0053E077
	public void PopCameraHandleByCloseView(EUiViewName viewName, EUiViewName? nextViewName, int closeViewId, EUiCameraHandleOperationType operationType)
	{
		UiCameraController.Instance.PopCameraHandleByCloseView((EUiViewName)this.CurSelectDango.DangoCamera, nextViewName, closeViewId, operationType);
	}

	// Token: 0x06011DA2 RID: 73122 RVA: 0x0053FE98 File Offset: 0x0053E098
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

	// Token: 0x06011DA3 RID: 73123 RVA: 0x0053FF34 File Offset: 0x0053E134
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

	// Token: 0x06011DA4 RID: 73124 RVA: 0x00540034 File Offset: 0x0053E234
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

	// Token: 0x06011DA5 RID: 73125 RVA: 0x00540088 File Offset: 0x0053E288
	private RacingBetsGearItem BetsGearItemCreate()
	{
		RacingBetsGearItem racingBetsGearItem = new RacingBetsGearItem();
		racingBetsGearItem.BindClickGearItemCallBack(new Action<RacingBettingGear>(this.OnClickGearItem));
		return racingBetsGearItem;
	}

	// Token: 0x06011DA6 RID: 73126 RVA: 0x005400A1 File Offset: 0x0053E2A1
	private RacingBetsDangoOddsItem DangoItemCreate()
	{
		RacingBetsDangoOddsItem racingBetsDangoOddsItem = new RacingBetsDangoOddsItem();
		racingBetsDangoOddsItem.BindClickGearItemCallBack(new Action<IRacingBetsDangoActorData>(this.OnClickDangoItem));
		return racingBetsDangoOddsItem;
	}

	// Token: 0x06011DA7 RID: 73127 RVA: 0x005400BC File Offset: 0x0053E2BC
	private void OnClickGearItem(RacingBettingGear data)
	{
		this.CurSelectGearConfig = new RacingBettingGear?(data);
		int gridIndex = -1;
		for (int i = 0; i < this.GearConfigList.Count; i++)
		{
			if (data.Id == this.GearConfigList[i].Id)
			{
				gridIndex = i;
				break;
			}
		}
		this.BetGearLayout.SelectGridProxy(gridIndex, false);
		this.RefreshBetsPanel(this.LegMatchData, this.CurSelectDango, this.CurSelectGearConfig.Value);
	}

	// Token: 0x06011DA8 RID: 73128 RVA: 0x00540138 File Offset: 0x0053E338
	private void OnClickDangoItem(IRacingBetsDangoActorData data)
	{
		this.CurSelectDango = data2;
		int num = this.DangoActorDataList.FindIndex((IRacingBetsDangoActorData data) => data == this.CurSelectDango);
		this.DangoLayout.SelectGridProxy(num, false);
		this.RefreshUi(this.LegMatchData, data2, this.CurSelectGearConfig.Value);
		this.SelectDangoActor(this.DangoActorList[num]);
		UiCameraModel.Instance.PushCameraHandleByHandleName(this.CurSelectDango.DangoCamera, true, true, "1001", false, null);
	}

	// Token: 0x06011DA9 RID: 73129 RVA: 0x005401BA File Offset: 0x0053E3BA
	private void OnClickCloseButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x06011DAA RID: 73130 RVA: 0x005401C4 File Offset: 0x0053E3C4
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

	// Token: 0x06011DAB RID: 73131 RVA: 0x00540230 File Offset: 0x0053E430
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

	// Token: 0x06011DAC RID: 73132 RVA: 0x0054026C File Offset: 0x0053E46C
	private void OnRacingBetsPlayerInfoUpdate()
	{
		this.RefreshUi(this.LegMatchData, this.CurSelectDango, this.CurSelectGearConfig.Value);
	}

	// Token: 0x06011DAD RID: 73133 RVA: 0x0054028C File Offset: 0x0053E48C
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

	// Token: 0x04009BCE RID: 39886
	private bool Tickable = true;

	// Token: 0x04009BCF RID: 39887
	private IRacingBetsDangoActorData CurSelectDango;

	// Token: 0x04009BD0 RID: 39888
	private RacingBettingGear? CurSelectGearConfig;

	// Token: 0x04009BD1 RID: 39889
	[Nullable(2)]
	private TsUiSceneDangoActor CurSelectDangoActor;

	// Token: 0x04009BD2 RID: 39890
	private RacingBetsLegMatchData LegMatchData;

	// Token: 0x04009BD3 RID: 39891
	private List<IRacingBetsDangoActorData> DangoActorDataList = new List<IRacingBetsDangoActorData>();

	// Token: 0x04009BD4 RID: 39892
	private List<TsUiSceneDangoActor> DangoActorList = new List<TsUiSceneDangoActor>();

	// Token: 0x04009BD5 RID: 39893
	private IReadOnlyList<RacingBettingGear> GearConfigList = new List<RacingBettingGear>();

	// Token: 0x04009BD6 RID: 39894
	private RacingBetsCostItem BetsCostItem;

	// Token: 0x04009BD7 RID: 39895
	private RacingBetsCostItem BetsRewardItem;

	// Token: 0x04009BD8 RID: 39896
	private RacingBetsCostItem BetsResultCostItem;

	// Token: 0x04009BD9 RID: 39897
	private RacingBetsCostItem BetsResultRewardItem;

	// Token: 0x04009BDA RID: 39898
	private CommonCurrencyItem CommonCurrencyItem;

	// Token: 0x04009BDB RID: 39899
	private GenericLayout<RacingBetsGearItem, RacingBettingGear> BetGearLayout;

	// Token: 0x04009BDC RID: 39900
	private GenericLayout<RacingBetsDangoOddsItem, IRacingBetsDangoActorData> DangoLayout;

	// Token: 0x02007F0A RID: 32522
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x040291C6 RID: 168390
		public const int DangoNameText = 0;

		// Token: 0x040291C7 RID: 168391
		public const int DangoSkillText = 1;

		// Token: 0x040291C8 RID: 168392
		public const int DangoLayout = 2;

		// Token: 0x040291C9 RID: 168393
		public const int LegMatchName = 3;

		// Token: 0x040291CA RID: 168394
		public const int BetPanel = 4;

		// Token: 0x040291CB RID: 168395
		public const int BetResultPanel = 5;

		// Token: 0x040291CC RID: 168396
		public const int CurrencyItem = 6;

		// Token: 0x040291CD RID: 168397
		public const int CloseButton = 7;

		// Token: 0x040291CE RID: 168398
		public const int BetsGearLayout = 8;

		// Token: 0x040291CF RID: 168399
		public const int BetsCostItem = 9;

		// Token: 0x040291D0 RID: 168400
		public const int BetsRewardItem = 10;

		// Token: 0x040291D1 RID: 168401
		public const int BetsButton = 11;

		// Token: 0x040291D2 RID: 168402
		public const int DangoTexture = 12;

		// Token: 0x040291D3 RID: 168403
		public const int DangoName = 13;

		// Token: 0x040291D4 RID: 168404
		public const int BetsResultCostItem = 14;

		// Token: 0x040291D5 RID: 168405
		public const int BetsResultRewardItem = 15;

		// Token: 0x040291D6 RID: 168406
		public const int RemainCancelItem = 16;

		// Token: 0x040291D7 RID: 168407
		public const int RemainCancelNumText = 17;

		// Token: 0x040291D8 RID: 168408
		public const int CancelButton = 18;

		// Token: 0x040291D9 RID: 168409
		public const int BetUpdateDescText = 19;

		// Token: 0x040291DA RID: 168410
		public const int BetUpdateTimeText = 20;

		// Token: 0x040291DB RID: 168411
		public const int TimeText = 21;

		// Token: 0x040291DC RID: 168412
		public const int TimeDescText = 22;

		// Token: 0x040291DD RID: 168413
		public const int BetOddsText = 23;

		// Token: 0x040291DE RID: 168414
		public const int NotBetOddsText = 24;

		// Token: 0x040291DF RID: 168415
		public const int OddsTimeItem = 25;

		// Token: 0x040291E0 RID: 168416
		public const int BetInfoPanel = 26;

		// Token: 0x040291E1 RID: 168417
		public const int AbuInfoPanel = 27;

		// Token: 0x040291E2 RID: 168418
		public const int AbuDescText = 28;
	}
}
