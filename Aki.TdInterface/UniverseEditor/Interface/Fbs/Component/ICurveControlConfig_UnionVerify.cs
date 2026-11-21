using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055B2 RID: 21938
	public static class ICurveControlConfig_UnionVerify
	{
		// Token: 0x06022E60 RID: 142944 RVA: 0x004CE378 File Offset: 0x004CC578
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IChargeSlashControlVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ICurveControlConfigVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
