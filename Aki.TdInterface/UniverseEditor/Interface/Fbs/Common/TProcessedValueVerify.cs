using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064D8 RID: 25816
	public static class TProcessedValueVerify
	{
		// Token: 0x0602BE11 RID: 179729 RVA: 0x005F754C File Offset: 0x005F574C
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
