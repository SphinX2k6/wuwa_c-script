using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F65 RID: 32613
	public static class TNpcLeisureInteractOpVerify
	{
		// Token: 0x0603ACAA RID: 240810 RVA: 0x007E72B0 File Offset: 0x007E54B0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = INpcExitCurrentInteractVerify.Verify(verifier, tablePos);
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
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
