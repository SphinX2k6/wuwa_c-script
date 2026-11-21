using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062FC RID: 25340
	public static class TTrampleTipOptionVerify
	{
		// Token: 0x0602B0CE RID: 176334 RVA: 0x005DE708 File Offset: 0x005DC908
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IMechaTrackCountDownTipVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ICountDownTextTipVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
