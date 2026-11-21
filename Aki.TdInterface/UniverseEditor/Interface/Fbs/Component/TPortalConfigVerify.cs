using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062BA RID: 25274
	public static class TPortalConfigVerify
	{
		// Token: 0x0602AF8C RID: 176012 RVA: 0x005DC970 File Offset: 0x005DAB70
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
