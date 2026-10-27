using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BC6 RID: 27590
	public static class INpcLeisureInteractType_UnionVerify
	{
		// Token: 0x0603077A RID: 198522 RVA: 0x00694D4C File Offset: 0x00692F4C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = INpcLeisureInteractTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = INpcSitDownVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = INpcSwingVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = INpcSwingGetUpVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = INpcExitCurrentInteractVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
