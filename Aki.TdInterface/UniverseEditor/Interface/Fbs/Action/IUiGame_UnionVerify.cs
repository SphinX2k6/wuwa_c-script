using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C9A RID: 31898
	public static class IUiGame_UnionVerify
	{
		// Token: 0x060398B4 RID: 235700 RVA: 0x007C4194 File Offset: 0x007C2394
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
				result = IFrequencyPaintVerify.Verify(verifier, tablePos);
				break;
			case 22:
				result = IFrequencyDetectVerify.Verify(verifier, tablePos);
				break;
			case 23:
				result = ITurntableConnectorUiGameplayVerify.Verify(verifier, tablePos);
				break;
			case 24:
				result = IFishingRouletteVerify.Verify(verifier, tablePos);
				break;
			case 25:
				result = IDaolingAuthenticationVerify.Verify(verifier, tablePos);
				break;
			case 26:
				result = IDragActorVerify.Verify(verifier, tablePos);
				break;
			case 27:
				result = IWuWaGoGameVerify.Verify(verifier, tablePos);
				break;
			case 28:
				result = IWriteLetterVerify.Verify(verifier, tablePos);
				break;
			case 29:
				result = IQteHourglassVerify.Verify(verifier, tablePos);
				break;
			case 30:
				result = IInstrumentQteGameplayVerify.Verify(verifier, tablePos);
				break;
			case 31:
				result = IPlayPianoGameplayVerify.Verify(verifier, tablePos);
				break;
			case 32:
				result = IDartGameplayVerify.Verify(verifier, tablePos);
				break;
			case 33:
				result = ISceneInspectionVerify.Verify(verifier, tablePos);
				break;
			case 34:
				result = ITuningStandVerify.Verify(verifier, tablePos);
				break;
			case 35:
				result = ITraceTracingVerify.Verify(verifier, tablePos);
				break;
			case 36:
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
