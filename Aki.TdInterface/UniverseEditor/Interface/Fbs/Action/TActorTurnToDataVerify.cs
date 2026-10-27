using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200763A RID: 30266
	public static class TActorTurnToDataVerify
	{
		// Token: 0x060371ED RID: 225773 RVA: 0x00779814 File Offset: 0x00777A14
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
