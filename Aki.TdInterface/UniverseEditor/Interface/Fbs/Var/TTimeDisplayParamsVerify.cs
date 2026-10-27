using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B5E RID: 15198
	public static class TTimeDisplayParamsVerify
	{
		// Token: 0x06014C9E RID: 85150 RVA: 0x00305274 File Offset: 0x00303474
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
