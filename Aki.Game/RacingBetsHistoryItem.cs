using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Dango.DangoLogic;
using CSharpScript.Game.Module.RacingBets;
using CSharpScript.Game.Module.RacingBets.Data;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001C1F RID: 7199
[Nullable(new byte[]
{
	0,
	1
})]
public class RacingBetsHistoryItem : GridProxyAbstract<RacingBetsLegMatchData>
{
	// Token: 0x06011E28 RID: 73256 RVA: 0x00542B90 File Offset: 0x00540D90
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(6, new Action(this.OnClickReplayBtn))
		};
	}

	// Token: 0x06011E29 RID: 73257 RVA: 0x00542C65 File Offset: 0x00540E65
	[NullableContext(1)]
	public override void Refresh(RacingBetsLegMatchData data, bool isSelected, int gridIndex)
	{
		this.LegMatchData = data;
		this.UpdateItem();
	}

	// Token: 0x06011E2A RID: 73258 RVA: 0x00542C74 File Offset: 0x00540E74
	private void UpdateItem()
	{
		if (this.LegMatchData == null)
		{
			return;
		}
		bool flag = this.LegMatchData.IsLegMatchFinished();
		int betDangoId = this.LegMatchData.BetDangoId;
		bool flag2 = betDangoId != 0;
		if (flag2)
		{
			DangoConfig instance = DangoConfig.Instance;
			Dango? dango = (instance != null) ? instance.GetDangoById(betDangoId) : null;
			string path = ((dango != null) ? dango.GetValueOrDefault().Icon : null) ?? "";
			base.SetTextureByPath(path, base.GetTexture(2), null, null);
			UUITexture texture = base.GetTexture(2);
			if (texture != null)
			{
				texture.SetUIActive(true);
			}
			base.GetText(3).ShowTextNew(((dango != null) ? dango.GetValueOrDefault().Name : null) ?? "");
		}
		else
		{
			UUITexture texture2 = base.GetTexture(2);
			if (texture2 != null)
			{
				texture2.SetUIActive(false);
			}
			base.GetText(3).SetText("-", true);
		}
		base.GetText(0).SetText(TimeUtil.Instance.DateFormat6String(this.LegMatchData.MatchStartTime), true);
		base.GetText(1).ShowTextNew(this.LegMatchData.Name);
		if (flag && flag2)
		{
			UUIText text = base.GetText(4);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.LegMatchData.GetBetDangoRank());
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			UUIText text2 = base.GetText(5);
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.LegMatchData.OddsReward);
			text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
		else
		{
			base.GetText(4).SetText("-", true);
			base.GetText(5).SetText("-", true);
		}
		base.GetButton(6).RootUIComp.Get().SetUIActive(flag);
	}

	// Token: 0x06011E2B RID: 73259 RVA: 0x00542E54 File Offset: 0x00541054
	private void OnClickReplayBtn()
	{
		if (this.LegMatchData == null)
		{
			Log.Instance.Error(ELogModule.RacingBets, ELogAuthor.LRC, "投注历史界面 item LegMatchData undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		RacingBetsSeasonData racingBetsSeasonData = RacingBetsModel.Instance.GetRacingBetsSeasonData();
		if (racingBetsSeasonData == null)
		{
			return;
		}
		RacingBetsController.Instance.RacingBetMatchActionRequest(racingBetsSeasonData.Id, this.LegMatchData.Id);
	}

	// Token: 0x04009BFF RID: 39935
	[Nullable(2)]
	private RacingBetsLegMatchData LegMatchData;

	// Token: 0x02007F24 RID: 32548
	private class EItemComponents
	{
		// Token: 0x04029280 RID: 168576
		public const int DateText = 0;

		// Token: 0x04029281 RID: 168577
		public const int LegNameText = 1;

		// Token: 0x04029282 RID: 168578
		public const int DangoTexture = 2;

		// Token: 0x04029283 RID: 168579
		public const int DangoName = 3;

		// Token: 0x04029284 RID: 168580
		public const int RankText = 4;

		// Token: 0x04029285 RID: 168581
		public const int EarnText = 5;

		// Token: 0x04029286 RID: 168582
		public const int ReplayButton = 6;
	}
}
