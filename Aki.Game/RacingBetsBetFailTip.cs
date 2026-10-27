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

// Token: 0x02002725 RID: 10021
public class RacingBetsBetFailTip : UiViewBase
{
	// Token: 0x060148A1 RID: 84129 RVA: 0x0053014F File Offset: 0x0052E34F
	[NullableContext(1)]
	public RacingBetsBetFailTip(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060148A2 RID: 84130 RVA: 0x00530158 File Offset: 0x0052E358
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

	// Token: 0x060148A3 RID: 84131 RVA: 0x00530288 File Offset: 0x0052E488
	protected override UniTask OnBeforeStartAsync()
	{
		RacingBetsBetFailTip.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RacingBetsBetFailTip.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060148A4 RID: 84132 RVA: 0x005302CC File Offset: 0x0052E4CC
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

	// Token: 0x060148A5 RID: 84133 RVA: 0x0053046E File Offset: 0x0052E66E
	private void OnClickConfirmButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x060148A6 RID: 84134 RVA: 0x00530478 File Offset: 0x0052E678
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

	// Token: 0x04009A72 RID: 39538
	private int LegMatchId;

	// Token: 0x04009A73 RID: 39539
	[Nullable(2)]
	private RacingBetsCostItem BetRewardItem;

	// Token: 0x02008D7D RID: 36221
	private enum EComponent
	{
		// Token: 0x0402DE94 RID: 188052
		RankText,
		// Token: 0x0402DE95 RID: 188053
		DangoIcon,
		// Token: 0x0402DE96 RID: 188054
		CostResultText,
		// Token: 0x0402DE97 RID: 188055
		CurrencyIcon,
		// Token: 0x0402DE98 RID: 188056
		BetRewardItem,
		// Token: 0x0402DE99 RID: 188057
		ConfirmButton,
		// Token: 0x0402DE9A RID: 188058
		ReplayButton,
		// Token: 0x0402DE9B RID: 188059
		WinnerDangoIcon,
		// Token: 0x0402DE9C RID: 188060
		WinnerDangoText,
		// Token: 0x0402DE9D RID: 188061
		MatchNameText
	}
}
