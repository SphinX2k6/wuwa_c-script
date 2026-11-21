using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x02001BAE RID: 7086
[NullableContext(1)]
[Nullable(0)]
public static class DangoDungeonCommandFactory
{
	// Token: 0x06011A8A RID: 72330 RVA: 0x00535BC1 File Offset: 0x00533DC1
	public static RacingBetsCommandBase CreateRacingBetsInitDungeonCommand(List<RacingBetsDungeonDangoInfo> dangoInfoList, IReadOnlyList<RacingBetMapPoint> mapPointList, int seasonId)
	{
		RacingBetsInitDungeonCommand racingBetsInitDungeonCommand = new RacingBetsInitDungeonCommand();
		racingBetsInitDungeonCommand.Init(dangoInfoList, mapPointList, seasonId);
		return racingBetsInitDungeonCommand;
	}

	// Token: 0x06011A8B RID: 72331 RVA: 0x00535BD1 File Offset: 0x00533DD1
	public static RacingBetsCommandBase CreateOpenRacingBetsGameplayView()
	{
		return new OpenRacingBetsGamePlayViewCommand();
	}

	// Token: 0x06011A8C RID: 72332 RVA: 0x00535BD8 File Offset: 0x00533DD8
	public static RacingBetsCommandBase CreateOpenRacingBetsGamePlayPreviewView(bool canCameraInput = false)
	{
		OpenRacingBetsGamePlayPreviewViewCommand openRacingBetsGamePlayPreviewViewCommand = new OpenRacingBetsGamePlayPreviewViewCommand();
		openRacingBetsGamePlayPreviewViewCommand.Init(canCameraInput);
		return openRacingBetsGamePlayPreviewViewCommand;
	}

	// Token: 0x06011A8D RID: 72333 RVA: 0x00535BE6 File Offset: 0x00533DE6
	public static RacingBetsCommandBase CreateRacingBetsDungeonBeginCommand()
	{
		return new RacingBetsDungeonBeginCommand();
	}

	// Token: 0x06011A8E RID: 72334 RVA: 0x00535BED File Offset: 0x00533DED
	public static RacingBetsCommandBase CreateRacingBetsRoundStartCommand()
	{
		return new RacingBetsRoundStartCommand();
	}

	// Token: 0x06011A8F RID: 72335 RVA: 0x00535BF4 File Offset: 0x00533DF4
	public static RacingBetsDangoRoundStartCommand CreateRacingBetsDangoRoundStartCommand(int dangoId)
	{
		RacingBetsDangoRoundStartCommand racingBetsDangoRoundStartCommand = new RacingBetsDangoRoundStartCommand();
		racingBetsDangoRoundStartCommand.Init(dangoId);
		return racingBetsDangoRoundStartCommand;
	}

	// Token: 0x06011A90 RID: 72336 RVA: 0x00535C02 File Offset: 0x00533E02
	public static RacingBetsCommandBase CreateRacingBetsDiceCommand(int round, List<DangoIdToDiceNum> dangoDiceList)
	{
		RacingBetsDiceCommand racingBetsDiceCommand = new RacingBetsDiceCommand();
		racingBetsDiceCommand.Init(round, dangoDiceList);
		return racingBetsDiceCommand;
	}

	// Token: 0x06011A91 RID: 72337 RVA: 0x00535C11 File Offset: 0x00533E11
	public static RacingBetsCommandBase CreateRacingBetsSkillCommand(RacingBetsDangoActionSkill skillAction)
	{
		RacingBetsSkillCommand racingBetsSkillCommand = new RacingBetsSkillCommand();
		racingBetsSkillCommand.Init(skillAction);
		return racingBetsSkillCommand;
	}

	// Token: 0x06011A92 RID: 72338 RVA: 0x00535C1F File Offset: 0x00533E1F
	public static RacingBetsCommandBase CreateRacingBetsDangoMoveCommand(RacingBetsDangoActionMove moveAction)
	{
		RacingBetsDangoMoveCommand racingBetsDangoMoveCommand = new RacingBetsDangoMoveCommand();
		racingBetsDangoMoveCommand.Init(moveAction);
		return racingBetsDangoMoveCommand;
	}

	// Token: 0x06011A93 RID: 72339 RVA: 0x00535C2D File Offset: 0x00533E2D
	public static RacingBetsCommandBase CreateRacingBetsDangoChangeHighCommand(RacingBetsDangoActionChangeHigh changeHighAction)
	{
		RacingBetsDangoChangeHighCommand racingBetsDangoChangeHighCommand = new RacingBetsDangoChangeHighCommand();
		racingBetsDangoChangeHighCommand.Init(changeHighAction);
		return racingBetsDangoChangeHighCommand;
	}

	// Token: 0x06011A94 RID: 72340 RVA: 0x00535C3B File Offset: 0x00533E3B
	public static RacingBetsCommandBase CreateRacingBetsChangeDangoCameraBlendCommand(int dangoId)
	{
		RacingBetsChangeDangoCameraBlendCommand racingBetsChangeDangoCameraBlendCommand = new RacingBetsChangeDangoCameraBlendCommand();
		racingBetsChangeDangoCameraBlendCommand.SetDangoId(dangoId);
		return racingBetsChangeDangoCameraBlendCommand;
	}

	// Token: 0x06011A95 RID: 72341 RVA: 0x00535C49 File Offset: 0x00533E49
	public static RacingBetsNextRoundRequestCommand CreateRacingBetsNextRoundRequestCommand(int activityId, int legMatchId, int roundId)
	{
		RacingBetsNextRoundRequestCommand racingBetsNextRoundRequestCommand = new RacingBetsNextRoundRequestCommand();
		racingBetsNextRoundRequestCommand.Init(activityId, legMatchId, roundId);
		return racingBetsNextRoundRequestCommand;
	}

	// Token: 0x06011A96 RID: 72342 RVA: 0x00535C59 File Offset: 0x00533E59
	public static OpenRacingBetsDungeonResultViewCommand CreateOpenRacingBetsDungeonResultView(RacingBetsLegMatchData legMatchData)
	{
		OpenRacingBetsDungeonResultViewCommand openRacingBetsDungeonResultViewCommand = new OpenRacingBetsDungeonResultViewCommand();
		openRacingBetsDungeonResultViewCommand.Init(legMatchData);
		return openRacingBetsDungeonResultViewCommand;
	}

	// Token: 0x06011A97 RID: 72343 RVA: 0x00535C67 File Offset: 0x00533E67
	public static RacingBetsDangoDestinationCommand CreateRacingBetsDangoDestinationCommand(int dangoId)
	{
		RacingBetsDangoDestinationCommand racingBetsDangoDestinationCommand = new RacingBetsDangoDestinationCommand();
		racingBetsDangoDestinationCommand.Init(dangoId);
		return racingBetsDangoDestinationCommand;
	}

	// Token: 0x06011A98 RID: 72344 RVA: 0x00535C75 File Offset: 0x00533E75
	public static RacingBetsDangoRankChangeCommand CreateRacingBetsDangoRankChangeCommand(List<int> rankList)
	{
		RacingBetsDangoRankChangeCommand racingBetsDangoRankChangeCommand = new RacingBetsDangoRankChangeCommand();
		racingBetsDangoRankChangeCommand.Init(rankList);
		return racingBetsDangoRankChangeCommand;
	}

	// Token: 0x06011A99 RID: 72345 RVA: 0x00535C83 File Offset: 0x00533E83
	public static RacingBetsCommandBase CreateRacingBetsDangoTransmitCommand(RacingBetsDangoActionTransmit transmitAction)
	{
		RacingBetsDangoTransmitCommand racingBetsDangoTransmitCommand = new RacingBetsDangoTransmitCommand();
		racingBetsDangoTransmitCommand.Init(transmitAction);
		return racingBetsDangoTransmitCommand;
	}

	// Token: 0x06011A9A RID: 72346 RVA: 0x00535C91 File Offset: 0x00533E91
	public static RacingBetsCommandBase CreateRacingBetsBlackHoleTransmitCommand(RacingBetsDangoActionBlackHoleTransmit transmitAction)
	{
		RacingBetsBlackHoleTransmitCommand racingBetsBlackHoleTransmitCommand = new RacingBetsBlackHoleTransmitCommand();
		racingBetsBlackHoleTransmitCommand.Init(transmitAction);
		return racingBetsBlackHoleTransmitCommand;
	}

	// Token: 0x06011A9B RID: 72347 RVA: 0x00535C9F File Offset: 0x00533E9F
	public static RacingBetsCommandBase CreateRacingBetsOrganEffectCommand(RacingBetsOrganEffect organEffectAction)
	{
		RacingBetsOrganEffectCommand racingBetsOrganEffectCommand = new RacingBetsOrganEffectCommand();
		racingBetsOrganEffectCommand.Init(organEffectAction);
		return racingBetsOrganEffectCommand;
	}
}
