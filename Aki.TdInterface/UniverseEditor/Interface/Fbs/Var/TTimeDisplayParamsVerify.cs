using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F66 RID: 16230
	public static class TTimeDisplayParamsVerify
	{
		// Token: 0x06016168 RID: 90472 RVA: 0x0032B80C File Offset: 0x00329A0C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ITimeDisplayParamsVarVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ITimeDisplayParamsConstantVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
