using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BB4 RID: 23476
	public static class INoRenderPortalMode_UnionVerify
	{
		// Token: 0x06026B42 RID: 158530 RVA: 0x0054C4C0 File Offset: 0x0054A6C0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IStaticNoRenderPortalVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = INoRenderPortalModeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
