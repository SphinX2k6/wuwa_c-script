using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005616 RID: 22038
	public static class INoRenderPortalMode_UnionVerify
	{
		// Token: 0x06024932 RID: 149810 RVA: 0x0050BEA8 File Offset: 0x0050A0A8
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
