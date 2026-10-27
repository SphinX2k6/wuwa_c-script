using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077F1 RID: 30705
	public static class TUiGameVerify
	{
		// Token: 0x06037B23 RID: 228131 RVA: 0x00787BAC File Offset: 0x00785DAC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IBrokenRockVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICipherGameplayVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IDaemonHackVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IDaolingAuthenticationVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IDartGameplayVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IDollGrabVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IDollGrabShowcaseVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IDragActorVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IFindSunSpiritVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = IFishingRouletteVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = IFlowerSeaEscapeVerify.Verify(verifier, tablePos);
				break;
			case 12:
				result = IInstrumentQteGameplayVerify.Verify(verifier, tablePos);
				break;
			case 13:
				result = IItemInspectionVerify.Verify(verifier, tablePos);
				break;
			case 14:
				result = ILifePointVerify.Verify(verifier, tablePos);
				break;
			case 15:
				result = IMorseCodeVerify.Verify(verifier, tablePos);
				break;
			case 16:
				result = IPlayPianoGameplayVerify.Verify(verifier, tablePos);
				break;
			case 17:
				result = IProjectionMachineVerify.Verify(verifier, tablePos);
				break;
			case 18:
				result = IProjectorPuzzleVerify.Verify(verifier, tablePos);
				break;
			case 19:
				result = IQteHourglassVerify.Verify(verifier, tablePos);
				break;
			case 20:
				result = IReignsVerify.Verify(verifier, tablePos);
				break;
			case 21:
				result = IRenjuChessVerify.Verify(verifier, tablePos);
				break;
			case 22:
				result = IRideFlyingCarVerify.Verify(verifier, tablePos);
				break;
			case 23:
				result = ISceneInspectionVerify.Verify(verifier, tablePos);
				break;
			case 24:
				result = ISheriffReasoningVerify.Verify(verifier, tablePos);
				break;
			case 25:
				result = ISignalBreakGameplayVerify.Verify(verifier, tablePos);
				break;
			case 26:
				result = ISignalDeviceVerify.Verify(verifier, tablePos);
				break;
			case 27:
				result = ISignalDevice2Verify.Verify(verifier, tablePos);
				break;
			case 28:
				result = ISundialPuzzleGameplayVerify.Verify(verifier, tablePos);
				break;
			case 29:
				result = ITraceTracingVerify.Verify(verifier, tablePos);
				break;
			case 30:
				result = ITuningStandVerify.Verify(verifier, tablePos);
				break;
			case 31:
				result = IWriteLetterVerify.Verify(verifier, tablePos);
				break;
			case 32:
				result = IWuWaGoGameVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
