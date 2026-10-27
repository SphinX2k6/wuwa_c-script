using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Dango.DangoLogic;
using CSharpScript.Game.Module.RacingBets;
using CSharpScript.Game.Module.RacingBets.Data;

// Token: 0x020026DB RID: 9947
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsDungeonDangoInfo
{
	// Token: 0x0601464E RID: 83534 RVA: 0x005285B0 File Offset: 0x005267B0
	public RacingBetsDungeonDangoInfo(RacingBetsInstanceDangoInfo message)
	{
		this.DangoId = message.DangoId;
		this.CurPoint = message.CurPoint;
		this.DiceId = message.DiceId;
		this.High = message.High;
		this.EntityId = MathUtils.Instance.LongToNumber(message.EntityId);
		this.BpId = message.BpId;
	}

	// Token: 0x0601464F RID: 83535 RVA: 0x00528618 File Offset: 0x00526818
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

	// Token: 0x06014650 RID: 83536 RVA: 0x0052869C File Offset: 0x0052689C
	public Dice? GetDiceConfig()
	{
		DangoConfig instance = DangoConfig.Instance;
		if (instance == null)
		{
			return null;
		}
		return instance.GetDiceById(this.DiceId);
	}

	// Token: 0x06014651 RID: 83537 RVA: 0x005286C8 File Offset: 0x005268C8
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

	// Token: 0x06014652 RID: 83538 RVA: 0x00528774 File Offset: 0x00526974
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

	// Token: 0x06014653 RID: 83539 RVA: 0x005287F8 File Offset: 0x005269F8
	public bool IsAbuDango()
	{
		DangoConfig instance = DangoConfig.Instance;
		Dango? dango = (instance != null) ? instance.GetDangoById(this.DangoId) : null;
		return dango != null && dango.GetValueOrDefault().Type == 1;
	}

	// Token: 0x04009934 RID: 39220
	public readonly int DangoId;

	// Token: 0x04009935 RID: 39221
	public readonly int DiceId;

	// Token: 0x04009936 RID: 39222
	public readonly long EntityId;

	// Token: 0x04009937 RID: 39223
	public readonly int BpId;

	// Token: 0x04009938 RID: 39224
	public int CurPoint;

	// Token: 0x04009939 RID: 39225
	public int High;

	// Token: 0x0400993A RID: 39226
	public int Rank;

	// Token: 0x0400993B RID: 39227
	public int LastRank;
}
