using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074A4 RID: 29860
	public static class IUiGame_UnionVerify
	{
		// Token: 0x060364AB RID: 222379 RVA: 0x0076113C File Offset: 0x0075F33C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IUiGameVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IReignsVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IFindSunSpiritVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IDollGrabVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IDollGrabShowcaseVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IDaemonHackVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IProjectionMachineVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IItemInspectionVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = ICipherGameplayVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = ISignalBreakGameplayVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = ISundialPuzzleGameplayVerify.Verify(verifier, tablePos);
				break;
			case 12:
				result = ISignalDeviceVerify.Verify(verifier, tablePos);
				break;
			case 13:
				result = ISignalDevice2Verify.Verify(verifier, tablePos);
				break;
			case 14:
				result = IMorseCodeVerify.Verify(verifier, tablePos);
				break;
			case 15:
				result = IRenjuChessVerify.Verify(verifier, tablePos);
				break;
			case 16:
				result = IProjectorPuzzleVerify.Verify(verifier, tablePos);
				break;
			case 17:
				result = ILifePointVerify.Verify(verifier, tablePos);
				break;
			case 18:
				result = IBrokenRockVerify.Verify(verifier, tablePos);
				break;
			case 19:
				result = IFlowerSeaEscapeVerify.Verify(verifier, tablePos);
				break;
			case 20:
				result = IRideFlyingCarVerify.Verify(verifier, tablePos);
				break;
			case 21:
				result = IFishingRouletteVerify.Verify(verifier, tablePos);
				break;
			case 22:
				result = IDaolingAuthenticationVerify.Verify(verifier, tablePos);
				break;
			case 23:
				result = IDragActorVerify.Verify(verifier, tablePos);
				break;
			case 24:
				result = IWuWaGoGameVerify.Verify(verifier, tablePos);
				break;
			case 25:
				result = IWriteLetterVerify.Verify(verifier, tablePos);
				break;
			case 26:
				result = IQteHourglassVerify.Verify(verifier, tablePos);
				break;
			case 27:
				result = IInstrumentQteGameplayVerify.Verify(verifier, tablePos);
				break;
			case 28:
				result = IPlayPianoGameplayVerify.Verify(verifier, tablePos);
				break;
			case 29:
				result = IDartGameplayVerify.Verify(verifier, tablePos);
				break;
			case 30:
				result = ISceneInspectionVerify.Verify(verifier, tablePos);
				break;
			case 31:
				result = ITuningStandVerify.Verify(verifier, tablePos);
				break;
			case 32:
				result = ITraceTracingVerify.Verify(verifier, tablePos);
				break;
			case 33:
				result = ISheriffReasoningVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
