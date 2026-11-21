using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C5E RID: 31838
	public static class ITrapDefensePlayerOperationType_UnionVerify
	{
		// Token: 0x06039632 RID: 235058 RVA: 0x007BF534 File Offset: 0x007BD734
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
