using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RacingBets;
using CSharpScript.Game.Module.RacingBets.Data;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002726 RID: 10022
public class RacingBetsBetSuccessTip : UiViewBase
{
	// Token: 0x060148A8 RID: 84136 RVA: 0x005304C8 File Offset: 0x0052E6C8
	[NullableContext(1)]
	public RacingBetsBetSuccessTip(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060148A9 RID: 84137 RVA: 0x005304D4 File Offset: 0x0052E6D4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIArtText)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickConfirmButton)),
			new ValueTuple<int, Delegate>(6, new Action(this.OnClickReplayButton))
		};
	}

	// Token: 0x060148AA RID: 84138 RVA: 0x005305D8 File Offset: 0x0052E7D8
	protected override UniTask OnBeforeStartAsync()
	{
		RacingBetsBetSuccessTip.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RacingBetsBetSuccessTip.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060148AB RID: 84139 RVA: 0x0053061C File Offset: 0x0052E81C
	protected override void OnBeforeShow()
	{
		RacingBetLegMatchResultNotify racingBetLegMatchResultNotify = this.OpenParam as RacingBetLegMatchResultNotify;
		if (racingBetLegMatchResultNotify == null)
		{
			Log.Instance.Error(ELogModule.RacingBets, ELogAuthor.BB, "RacingBetsSuccessTip OnBeforeShow matchResult is undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		RacingBetsSeasonData racingBetsSeasonData = RacingBetsModel.Instance.GetRacingBetsSeasonData();
		if (racingBetsSeasonData == null)
		{
			return;
		}
		RacingBetsLegMatchData legMatchData = racingBetsSeasonData.GetLegMatchData(racingBetLegMatchResultNotify.LegMatchId);
		this.LegMatchId = racingBetLegMatchResultNotify.LegMatchId;
		UUIArtText artText = base.GetArtText(0);
		if (artText != null)
		{
			artText.SetText(racingBetLegMatchResultNotify.BetDangoRank.ToString());
		}
		DangoData dangoData = DangoManager.Instance.GetDangoData(racingBetLegMatchResultNotify.BetDangoId);
		int currencyItemId = racingBetsSeasonData.GetCurrencyItemId();
		InventoryConfig instance = InventoryConfig.Instance;
		ItemConfig itemConfig = (instance != null) ? instance.GetItemConfigData(currencyItemId) : null;
		if (itemConfig != null)
		{
			base.SetTextureShowUntilLoaded(itemConfig.Icon, base.GetTexture(3), null);
		}
		UUIText text = base.GetText(2);
		if (text != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(racingBetLegMatchResultNotify.BetCount);
			defaultInterpolatedStringHandler.AppendLiteral(" x ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(racingBetLegMatchResultNotify.Odds / 100);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
		RacingBetsCostItem betRewardItem = this.BetRewardItem;
		if (betRewardItem != null)
		{
			betRewardItem.RefreshUi(currencyItemId, racingBetLegMatchResultNotify.Reward);
		}
		base.SetTextureShowUntilLoaded(dangoData.IconAttackLarge, base.GetTexture(1), null);
		UUIText text2 = base.GetText(7);
		if (text2 == null)
		{
			return;
		}
		text2.ShowTextNew(((legMatchData != null) ? legMatchData.Name : null) ?? "");
	}

	// Token: 0x060148AC RID: 84140 RVA: 0x00530788 File Offset: 0x0052E988
	private void OnClickConfirmButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x060148AD RID: 84141 RVA: 0x00530794 File Offset: 0x0052E994
	private void OnClickReplayButton()
	{
		RacingBetsSeasonData racingBetsSeasonData = RacingBetsModel.Instance.GetRacingBetsSeasonData();
		if (racingBetsSeasonData == null)
		{
			return;
		}
		if (racingBetsSeasonData.GetLegMatchData(this.LegMatchId) == null)
		{
			return;
		}
		RacingBetsController.Instance.RacingBetMatchActionRequest(racingBetsSeasonData.Id, this.LegMatchId);
		base.CloseMe(null);
	}

	// Token: 0x04009A74 RID: 39540
	private int LegMatchId;

	// Token: 0x04009A75 RID: 39541
	[Nullable(2)]
	private RacingBetsCostItem BetRewardItem;

	// Token: 0x02008D7F RID: 36223
	private enum EComponent
	{
		// Token: 0x0402DEA3 RID: 188067
		RankText,
		// Token: 0x0402DEA4 RID: 188068
		DangoIcon,
		// Token: 0x0402DEA5 RID: 188069
		CostResultText,
		// Token: 0x0402DEA6 RID: 188070
		CurrencyIcon,
		// Token: 0x0402DEA7 RID: 188071
		BetRewardItem,
		// Token: 0x0402DEA8 RID: 188072
		ConfirmButton,
		// Token: 0x0402DEA9 RID: 188073
		ReplayButton,
		// Token: 0x0402DEAA RID: 188074
		MatchNameText
	}
}
