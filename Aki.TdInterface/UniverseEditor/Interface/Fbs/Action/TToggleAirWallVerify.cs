using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077DC RID: 30684
	public static class TToggleAirWallVerify
	{
		// Token: 0x06037A8D RID: 227981 RVA: 0x00786DC4 File Offset: 0x00784FC4
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
