using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E95 RID: 24213
	public static class TProcessedValueVerify
	{
		// Token: 0x06029769 RID: 169833 RVA: 0x005AE5A8 File Offset: 0x005AC7A8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IProcessedValueConstraintVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IProcessedValueConstantVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
