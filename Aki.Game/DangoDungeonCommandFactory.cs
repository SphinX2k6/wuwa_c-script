using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x020026C3 RID: 9923
[NullableContext(1)]
[Nullable(0)]
public static class DangoDungeonCommandFactory
{
	// Token: 0x060145A8 RID: 83368 RVA: 0x00526E89 File Offset: 0x00525089
	public static RacingBetsCommandBase CreateRacingBetsInitDungeonCommand(List<RacingBetsDungeonDangoInfo> dangoInfoList, IReadOnlyList<RacingBetMapPoint> mapPointList, int seasonId)
	{
		RacingBetsInitDungeonCommand racingBetsInitDungeonCommand = new RacingBetsInitDungeonCommand();
		racingBetsInitDungeonCommand.Init(dangoInfoList, mapPointList, seasonId);
		return racingBetsInitDungeonCommand;
	}

	// Token: 0x060145A9 RID: 83369 RVA: 0x00526E99 File Offset: 0x00525099
	public static RacingBetsCommandBase CreateOpenRacingBetsGameplayView()
	{
		return new OpenRacingBetsGamePlayViewCommand();
	}

	// Token: 0x060145AA RID: 83370 RVA: 0x00526EA0 File Offset: 0x005250A0
	public static RacingBetsCommandBase CreateOpenRacingBetsGamePlayPreviewView(bool canCameraInput = false)
	{
		OpenRacingBetsGamePlayPreviewViewCommand openRacingBetsGamePlayPreviewViewCommand = new OpenRacingBetsGamePlayPreviewViewCommand();
		openRacingBetsGamePlayPreviewViewCommand.Init(canCameraInput);
		return openRacingBetsGamePlayPreviewViewCommand;
	}

	// Token: 0x060145AB RID: 83371 RVA: 0x00526EAE File Offset: 0x005250AE
	public static RacingBetsCommandBase CreateRacingBetsDungeonBeginCommand()
	{
		return new RacingBetsDungeonBeginCommand();
	}

	// Token: 0x060145AC RID: 83372 RVA: 0x00526EB5 File Offset: 0x005250B5
	public static RacingBetsCommandBase CreateRacingBetsRoundStartCommand()
	{
		return new RacingBetsRoundStartCommand();
	}

	// Token: 0x060145AD RID: 83373 RVA: 0x00526EBC File Offset: 0x005250BC
	public static RacingBetsDangoRoundStartCommand CreateRacingBetsDangoRoundStartCommand(int dangoId)
	{
		RacingBetsDangoRoundStartCommand racingBetsDangoRoundStartCommand = new RacingBetsDangoRoundStartCommand();
		racingBetsDangoRoundStartCommand.Init(dangoId);
		return racingBetsDangoRoundStartCommand;
	}

	// Token: 0x060145AE RID: 83374 RVA: 0x00526ECA File Offset: 0x005250CA
	public static RacingBetsCommandBase CreateRacingBetsDiceCommand(int round, List<DangoIdToDiceNum> dangoDiceList)
	{
		RacingBetsDiceCommand racingBetsDiceCommand = new RacingBetsDiceCommand();
		racingBetsDiceCommand.Init(round, dangoDiceList);
		return racingBetsDiceCommand;
	}

	// Token: 0x060145AF RID: 83375 RVA: 0x00526ED9 File Offset: 0x005250D9
	public static RacingBetsCommandBase CreateRacingBetsSkillCommand(RacingBetsDangoActionSkill skillAction)
	{
		RacingBetsSkillCommand racingBetsSkillCommand = new RacingBetsSkillCommand();
		racingBetsSkillCommand.Init(skillAction);
		return racingBetsSkillCommand;
	}

	// Token: 0x060145B0 RID: 83376 RVA: 0x00526EE7 File Offset: 0x005250E7
	public static RacingBetsCommandBase CreateRacingBetsDangoMoveCommand(RacingBetsDangoActionMove moveAction)
	{
		RacingBetsDangoMoveCommand racingBetsDangoMoveCommand = new RacingBetsDangoMoveCommand();
		racingBetsDangoMoveCommand.Init(moveAction);
		return racingBetsDangoMoveCommand;
	}

	// Token: 0x060145B1 RID: 83377 RVA: 0x00526EF5 File Offset: 0x005250F5
	public static RacingBetsCommandBase CreateRacingBetsDangoChangeHighCommand(RacingBetsDangoActionChangeHigh changeHighAction)
	{
		RacingBetsDangoChangeHighCommand racingBetsDangoChangeHighCommand = new RacingBetsDangoChangeHighCommand();
		racingBetsDangoChangeHighCommand.Init(changeHighAction);
		return racingBetsDangoChangeHighCommand;
	}

	// Token: 0x060145B2 RID: 83378 RVA: 0x00526F03 File Offset: 0x00525103
	public static RacingBetsCommandBase CreateRacingBetsChangeDangoCameraBlendCommand(int dangoId)
	{
		RacingBetsChangeDangoCameraBlendCommand racingBetsChangeDangoCameraBlendCommand = new RacingBetsChangeDangoCameraBlendCommand();
		racingBetsChangeDangoCameraBlendCommand.SetDangoId(dangoId);
		return racingBetsChangeDangoCameraBlendCommand;
	}

	// Token: 0x060145B3 RID: 83379 RVA: 0x00526F11 File Offset: 0x00525111
	public static RacingBetsNextRoundRequestCommand CreateRacingBetsNextRoundRequestCommand(int activityId, int legMatchId, int roundId)
	{
		RacingBetsNextRoundRequestCommand racingBetsNextRoundRequestCommand = new RacingBetsNextRoundRequestCommand();
		racingBetsNextRoundRequestCommand.Init(activityId, legMatchId, roundId);
		return racingBetsNextRoundRequestCommand;
	}

	// Token: 0x060145B4 RID: 83380 RVA: 0x00526F21 File Offset: 0x00525121
	public static OpenRacingBetsDungeonResultViewCommand CreateOpenRacingBetsDungeonResultView(RacingBetsLegMatchData legMatchData)
	{
		OpenRacingBetsDungeonResultViewCommand openRacingBetsDungeonResultViewCommand = new OpenRacingBetsDungeonResultViewCommand();
		openRacingBetsDungeonResultViewCommand.Init(legMatchData);
		return openRacingBetsDungeonResultViewCommand;
	}

	// Token: 0x060145B5 RID: 83381 RVA: 0x00526F2F File Offset: 0x0052512F
	public static RacingBetsDangoDestinationCommand CreateRacingBetsDangoDestinationCommand(int dangoId)
	{
		RacingBetsDangoDestinationCommand racingBetsDangoDestinationCommand = new RacingBetsDangoDestinationCommand();
		racingBetsDangoDestinationCommand.Init(dangoId);
		return racingBetsDangoDestinationCommand;
	}

	// Token: 0x060145B6 RID: 83382 RVA: 0x00526F3D File Offset: 0x0052513D
	public static RacingBetsDangoRankChangeCommand CreateRacingBetsDangoRankChangeCommand(List<int> rankList)
	{
		RacingBetsDangoRankChangeCommand racingBetsDangoRankChangeCommand = new RacingBetsDangoRankChangeCommand();
		racingBetsDangoRankChangeCommand.Init(rankList);
		return racingBetsDangoRankChangeCommand;
	}

	// Token: 0x060145B7 RID: 83383 RVA: 0x00526F4B File Offset: 0x0052514B
	public static RacingBetsCommandBase CreateRacingBetsDangoTransmitCommand(RacingBetsDangoActionTransmit transmitAction)
	{
		RacingBetsDangoTransmitCommand racingBetsDangoTransmitCommand = new RacingBetsDangoTransmitCommand();
		racingBetsDangoTransmitCommand.Init(transmitAction);
		return racingBetsDangoTransmitCommand;
	}

	// Token: 0x060145B8 RID: 83384 RVA: 0x00526F59 File Offset: 0x00525159
	public static RacingBetsCommandBase CreateRacingBetsBlackHoleTransmitCommand(RacingBetsDangoActionBlackHoleTransmit transmitAction)
	{
		RacingBetsBlackHoleTransmitCommand racingBetsBlackHoleTransmitCommand = new RacingBetsBlackHoleTransmitCommand();
		racingBetsBlackHoleTransmitCommand.Init(transmitAction);
		return racingBetsBlackHoleTransmitCommand;
	}

	// Token: 0x060145B9 RID: 83385 RVA: 0x00526F67 File Offset: 0x00525167
	public static RacingBetsCommandBase CreateRacingBetsOrganEffectCommand(RacingBetsOrganEffect organEffectAction)
	{
		RacingBetsOrganEffectCommand racingBetsOrganEffectCommand = new RacingBetsOrganEffectCommand();
		racingBetsOrganEffectCommand.Init(organEffectAction);
		return racingBetsOrganEffectCommand;
	}
}
