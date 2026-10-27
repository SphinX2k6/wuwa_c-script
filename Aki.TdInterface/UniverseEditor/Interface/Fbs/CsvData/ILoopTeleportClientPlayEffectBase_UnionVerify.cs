using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x0200490D RID: 18701
	public static class ILoopTeleportClientPlayEffectBase_UnionVerify
	{
		// Token: 0x0601D3C1 RID: 119745 RVA: 0x0041FB44 File Offset: 0x0041DD44
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ILoopTeleportClientPlayEffectBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ILoopTeleportClientScreenEffectVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ILoopTeleportClientMpcEffectVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
