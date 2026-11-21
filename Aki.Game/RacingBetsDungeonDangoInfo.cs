using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Dango.DangoLogic;
using CSharpScript.Game.Module.RacingBets;
using CSharpScript.Game.Module.RacingBets.Data;

// Token: 0x02001BC6 RID: 7110
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsDungeonDangoInfo
{
	// Token: 0x06011B30 RID: 72496 RVA: 0x005372E8 File Offset: 0x005354E8
	public RacingBetsDungeonDangoInfo(RacingBetsInstanceDangoInfo message)
	{
		this.DangoId = message.DangoId;
		this.CurPoint = message.CurPoint;
		this.DiceId = message.DiceId;
		this.High = message.High;
		this.EntityId = MathUtils.Instance.LongToNumber(message.EntityId);
		this.BpId = message.BpId;
	}

	// Token: 0x06011B31 RID: 72497 RVA: 0x00537350 File Offset: 0x00535550
	public int RealPoint()
	{
		RacingBetsSeasonData racingBetsSeasonData = RacingBetsModel.Instance.GetRacingBetsSeasonData();
		int? num = (racingBetsSeasonData != null) ? new int?(racingBetsSeasonData.Id) : null;
		if (num == null)
		{
			Log.Instance.Error(ELogModule.RacingBets, ELogAuthor.LRC, "无法获取当前赛季ID", default(ReadOnlySpan<ValueTuple<string, object>>));
			return 0;
		}
		RacingBetsConfig instance = RacingBetsConfig.Instance;
		int num2 = (instance != null) ? instance.GetPointTotal(num.Value) : 0;
		return ((this.CurPoint - 1) % num2 + num2) % num2 + 1;
	}

	// Token: 0x06011B32 RID: 72498 RVA: 0x005373D4 File Offset: 0x005355D4
	public Dice? GetDiceConfig()
	{
		DangoConfig instance = DangoConfig.Instance;
		if (instance == null)
		{
			return null;
		}
		return instance.GetDiceById(this.DiceId);
	}

	// Token: 0x06011B33 RID: 72499 RVA: 0x00537400 File Offset: 0x00535600
	public string GetDiceIcon(int diceNum)
	{
		Dice? diceConfig = this.GetDiceConfig();
		if (diceConfig == null)
		{
			return "";
		}
		switch (diceNum)
		{
		case 1:
			return diceConfig.Value.DicePointOneIcon;
		case 2:
			return diceConfig.Value.DicePointTwoIcon;
		case 3:
			return diceConfig.Value.DicePointThreeIcon;
		case 4:
			return diceConfig.Value.DicePointFourIcon;
		case 5:
			return diceConfig.Value.DicePointFiveIcon;
		case 6:
			return diceConfig.Value.DicePointSixIcon;
		default:
			return "";
		}
	}

	// Token: 0x06011B34 RID: 72500 RVA: 0x005374AC File Offset: 0x005356AC
	public bool IsHalfPass()
	{
		RacingBetsSeasonData racingBetsSeasonData = RacingBetsModel.Instance.GetRacingBetsSeasonData();
		int? num = (racingBetsSeasonData != null) ? new int?(racingBetsSeasonData.Id) : null;
		if (num == null)
		{
			Log.Instance.Error(ELogModule.RacingBets, ELogAuthor.LRC, "无法获取当前赛季ID", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		RacingBetsConfig instance = RacingBetsConfig.Instance;
		int num2 = (instance != null) ? instance.GetPointTotal(num.Value) : 0;
		return this.CurPoint >= num2 / 2;
	}

	// Token: 0x06011B35 RID: 72501 RVA: 0x00537530 File Offset: 0x00535730
	public bool IsAbuDango()
	{
		DangoConfig instance = DangoConfig.Instance;
		Dango? dango = (instance != null) ? instance.GetDangoById(this.DangoId) : null;
		return dango != null && dango.GetValueOrDefault().Type == 1;
	}

	// Token: 0x04009A8C RID: 39564
	public readonly int DangoId;

	// Token: 0x04009A8D RID: 39565
	public readonly int DiceId;

	// Token: 0x04009A8E RID: 39566
	public readonly long EntityId;

	// Token: 0x04009A8F RID: 39567
	public readonly int BpId;

	// Token: 0x04009A90 RID: 39568
	public int CurPoint;

	// Token: 0x04009A91 RID: 39569
	public int High;

	// Token: 0x04009A92 RID: 39570
	public int Rank;

	// Token: 0x04009A93 RID: 39571
	public int LastRank;
}
