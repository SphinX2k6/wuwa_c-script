using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077EE RID: 30702
	public static class TTrapDefensePlayerOperationTypeVerify
	{
		// Token: 0x06037ADB RID: 228059 RVA: 0x00787480 File Offset: 0x00785680
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
