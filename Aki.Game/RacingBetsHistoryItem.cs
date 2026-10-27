using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Dango.DangoLogic;
using CSharpScript.Game.Module.RacingBets;
using CSharpScript.Game.Module.RacingBets.Data;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002734 RID: 10036
[Nullable(new byte[]
{
	0,
	1
})]
public class RacingBetsHistoryItem : GridProxyAbstract<RacingBetsLegMatchData>
{
	// Token: 0x06014946 RID: 84294 RVA: 0x00533E80 File Offset: 0x00532080
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

	// Token: 0x06014947 RID: 84295 RVA: 0x00533F55 File Offset: 0x00532155
	[NullableContext(1)]
	public override void Refresh(RacingBetsLegMatchData data, bool isSelected, int gridIndex)
	{
		this.LegMatchData = data;
		this.UpdateItem();
	}

	// Token: 0x06014948 RID: 84296 RVA: 0x00533F64 File Offset: 0x00532164
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

	// Token: 0x06014949 RID: 84297 RVA: 0x00534144 File Offset: 0x00532344
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

	// Token: 0x04009AA7 RID: 39591
	[Nullable(2)]
	private RacingBetsLegMatchData LegMatchData;

	// Token: 0x02008D9C RID: 36252
	private class EItemComponents
	{
		// Token: 0x0402DF6A RID: 188266
		public const int DateText = 0;

		// Token: 0x0402DF6B RID: 188267
		public const int LegNameText = 1;

		// Token: 0x0402DF6C RID: 188268
		public const int DangoTexture = 2;

		// Token: 0x0402DF6D RID: 188269
		public const int DangoName = 3;

		// Token: 0x0402DF6E RID: 188270
		public const int RankText = 4;

		// Token: 0x0402DF6F RID: 188271
		public const int EarnText = 5;

		// Token: 0x0402DF70 RID: 188272
		public const int ReplayButton = 6;
	}
}
