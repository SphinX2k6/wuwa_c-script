using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E48 RID: 32328
	public static class TActorTurnToDataVerify
	{
		// Token: 0x0603A692 RID: 239250 RVA: 0x007DD910 File Offset: 0x007DBB10
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IActorTurnToEmptyDataVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IActorTurnToEntityDataVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IActorTurnToPlayerDataVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IActorTurnToPositionDataVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IActorTurnToTalkerDataVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
