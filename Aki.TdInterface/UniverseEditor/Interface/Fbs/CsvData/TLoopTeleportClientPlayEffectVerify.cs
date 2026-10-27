using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x0200491C RID: 18716
	public static class TLoopTeleportClientPlayEffectVerify
	{
		// Token: 0x0601D465 RID: 119909 RVA: 0x00421254 File Offset: 0x0041F454
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
