using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200802C RID: 32812
	public static class TTrapDefensePlayerOperationTypeVerify
	{
		// Token: 0x0603B07A RID: 241786 RVA: 0x007ECD2C File Offset: 0x007EAF2C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITrapDefensePlayerOperationConstructTrapVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ITrapDefensePlayerOperationRecycleTrapVerify.Verify(verifier, tablePos);
				break;
			case 3:
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
