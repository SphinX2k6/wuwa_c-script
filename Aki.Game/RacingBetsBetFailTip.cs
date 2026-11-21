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

// Token: 0x02001C10 RID: 7184
public class RacingBetsBetFailTip : UiViewBase
{
	// Token: 0x06011D83 RID: 73091 RVA: 0x0053EE6B File Offset: 0x0053D06B
	[NullableContext(1)]
	public RacingBetsBetFailTip(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011D84 RID: 73092 RVA: 0x0053EE74 File Offset: 0x0053D074
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
			new ValueTuple<int, Type>(7, typeof(UUITexture)),
			new ValueTuple<int, Type>(8, typeof(UUIArtText)),
			new ValueTuple<int, Type>(9, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickConfirmButton)),
			new ValueTuple<int, Delegate>(6, new Action(this.OnClickReplayButton))
		};
	}

	// Token: 0x06011D85 RID: 73093 RVA: 0x0053EFA4 File Offset: 0x0053D1A4
	protected override UniTask OnBeforeStartAsync()
	{
		RacingBetsBetFailTip.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RacingBetsBetFailTip.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011D86 RID: 73094 RVA: 0x0053EFE8 File Offset: 0x0053D1E8
	protected override void OnBeforeShow()
	{
		RacingBetLegMatchResultNotify racingBetLegMatchResultNotify = this.OpenParam as RacingBetLegMatchResultNotify;
		if (racingBetLegMatchResultNotify == null)
		{
			Log.Instance.Error(ELogModule.RacingBets, ELogAuthor.BB, "RacingBetsFailTip OnBeforeShow matchResult is undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
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
		int racingBetConversionRate = RacingBetsConfig.Instance.GetRacingBetConversionRate(racingBetLegMatchResultNotify.BetDangoRank);
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
			defaultInterpolatedStringHandler.AppendFormatted<int>(racingBetConversionRate / 100);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
		RacingBetsCostItem betRewardItem = this.BetRewardItem;
		if (betRewardItem != null)
		{
			betRewardItem.RefreshUi(currencyItemId, racingBetLegMatchResultNotify.Reward);
		}
		DangoData dangoData = DangoManager.Instance.GetDangoData(racingBetLegMatchResultNotify.BetDangoId);
		DangoData dangoData2 = DangoManager.Instance.GetDangoData(racingBetLegMatchResultNotify.WinnerDangoId);
		base.SetTextureShowUntilLoaded(dangoData2.IconAttack, base.GetTexture(7), null);
		base.SetTextureShowUntilLoaded(dangoData.IconDamageLarge, base.GetTexture(1), null);
		UUIText text2 = base.GetText(9);
		if (text2 == null)
		{
			return;
		}
		text2.ShowTextNew(((legMatchData != null) ? legMatchData.Name : null) ?? "");
	}

	// Token: 0x06011D87 RID: 73095 RVA: 0x0053F18A File Offset: 0x0053D38A
	private void OnClickConfirmButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x06011D88 RID: 73096 RVA: 0x0053F194 File Offset: 0x0053D394
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

	// Token: 0x04009BCA RID: 39882
	private int LegMatchId;

	// Token: 0x04009BCB RID: 39883
	[Nullable(2)]
	private RacingBetsCostItem BetRewardItem;

	// Token: 0x02007F06 RID: 32518
	private enum EComponent
	{
		// Token: 0x040291AB RID: 168363
		RankText,
		// Token: 0x040291AC RID: 168364
		DangoIcon,
		// Token: 0x040291AD RID: 168365
		CostResultText,
		// Token: 0x040291AE RID: 168366
		CurrencyIcon,
		// Token: 0x040291AF RID: 168367
		BetRewardItem,
		// Token: 0x040291B0 RID: 168368
		ConfirmButton,
		// Token: 0x040291B1 RID: 168369
		ReplayButton,
		// Token: 0x040291B2 RID: 168370
		WinnerDangoIcon,
		// Token: 0x040291B3 RID: 168371
		WinnerDangoText,
		// Token: 0x040291B4 RID: 168372
		MatchNameText
	}
}
