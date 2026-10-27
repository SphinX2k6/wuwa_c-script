using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200773C RID: 30524
	public static class TNpcLeisureInteractOpVerify
	{
		// Token: 0x0603776F RID: 227183 RVA: 0x00782320 File Offset: 0x00780520
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
