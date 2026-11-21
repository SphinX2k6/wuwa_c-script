using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004DA8 RID: 19880
	public static class ILoopTeleportClientPlayEffectBase_UnionVerify
	{
		// Token: 0x0601ED5A RID: 126298 RVA: 0x0044F2A4 File Offset: 0x0044D4A4
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
