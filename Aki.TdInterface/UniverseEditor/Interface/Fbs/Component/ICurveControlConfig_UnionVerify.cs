using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005050 RID: 20560
	public static class ICurveControlConfig_UnionVerify
	{
		// Token: 0x06020F26 RID: 134950 RVA: 0x004946C4 File Offset: 0x004928C4
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
