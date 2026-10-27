using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200746B RID: 29803
	public static class ITrapDefensePlayerOperationType_UnionVerify
	{
		// Token: 0x06036249 RID: 221769 RVA: 0x0075C808 File Offset: 0x0075AA08
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITrapDefensePlayerOperationTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ITrapDefensePlayerOperationRecycleTrapVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ITrapDefensePlayerOperationConstructTrapVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ITrapDefensePlayerOperationSpawnMonsterVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
