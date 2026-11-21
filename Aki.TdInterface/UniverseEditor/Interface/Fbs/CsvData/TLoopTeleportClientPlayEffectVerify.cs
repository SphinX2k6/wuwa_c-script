using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004DCF RID: 19919
	public static class TLoopTeleportClientPlayEffectVerify
	{
		// Token: 0x0601EE8A RID: 126602 RVA: 0x00451708 File Offset: 0x0044F908
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ILoopTeleportClientScreenEffectVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ILoopTeleportClientMpcEffectVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
