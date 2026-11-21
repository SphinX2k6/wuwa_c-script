using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200732A RID: 29482
	public static class INpcLeisureInteractType_UnionVerify
	{
		// Token: 0x06033696 RID: 210582 RVA: 0x006EE64C File Offset: 0x006EC84C
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
