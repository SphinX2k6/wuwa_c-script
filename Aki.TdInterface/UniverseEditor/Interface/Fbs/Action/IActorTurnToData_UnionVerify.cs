using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006762 RID: 26466
	public static class IActorTurnToData_UnionVerify
	{
		// Token: 0x0602CDBD RID: 183741 RVA: 0x006226D4 File Offset: 0x006208D4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IActorTurnToDataVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IActorTurnToTalkerDataVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IActorTurnToEmptyDataVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IActorTurnToEntityDataVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IActorTurnToPositionDataVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IActorTurnToPlayerDataVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
