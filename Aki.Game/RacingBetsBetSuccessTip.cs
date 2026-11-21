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

// Token: 0x02001C11 RID: 7185
public class RacingBetsBetSuccessTip : UiViewBase
{
	// Token: 0x06011D8A RID: 73098 RVA: 0x0053F1E4 File Offset: 0x0053D3E4
	[NullableContext(1)]
	public RacingBetsBetSuccessTip(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011D8B RID: 73099 RVA: 0x0053F1F0 File Offset: 0x0053D3F0
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

	// Token: 0x06011D8C RID: 73100 RVA: 0x0053F2F4 File Offset: 0x0053D4F4
	protected override UniTask OnBeforeStartAsync()
	{
		RacingBetsBetSuccessTip.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RacingBetsBetSuccessTip.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011D8D RID: 73101 RVA: 0x0053F338 File Offset: 0x0053D538
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

	// Token: 0x06011D8E RID: 73102 RVA: 0x0053F4A4 File Offset: 0x0053D6A4
	private void OnClickConfirmButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x06011D8F RID: 73103 RVA: 0x0053F4B0 File Offset: 0x0053D6B0
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

	// Token: 0x04009BCC RID: 39884
	private int LegMatchId;

	// Token: 0x04009BCD RID: 39885
	[Nullable(2)]
	private RacingBetsCostItem BetRewardItem;

	// Token: 0x02007F08 RID: 32520
	private enum EComponent
	{
		// Token: 0x040291BA RID: 168378
		RankText,
		// Token: 0x040291BB RID: 168379
		DangoIcon,
		// Token: 0x040291BC RID: 168380
		CostResultText,
		// Token: 0x040291BD RID: 168381
		CurrencyIcon,
		// Token: 0x040291BE RID: 168382
		BetRewardItem,
		// Token: 0x040291BF RID: 168383
		ConfirmButton,
		// Token: 0x040291C0 RID: 168384
		ReplayButton,
		// Token: 0x040291C1 RID: 168385
		MatchNameText
	}
}
