using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006100 RID: 24832
	public static class IActorTurnToData_UnionVerify
	{
		// Token: 0x0602A6DC RID: 173788 RVA: 0x005D872C File Offset: 0x005D692C
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
