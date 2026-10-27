using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C89 RID: 23689
	public static class TPortalConfigVerify
	{
		// Token: 0x06028946 RID: 166214 RVA: 0x00594238 File Offset: 0x00592438
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IStaticPortalVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IDynamicPortalVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
