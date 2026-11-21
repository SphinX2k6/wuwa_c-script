using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02008017 RID: 32791
	public static class TToggleAirWallVerify
	{
		// Token: 0x0603B020 RID: 241696 RVA: 0x007EC574 File Offset: 0x007EA774
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IOpenAirWallVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ICloseAirWallVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
