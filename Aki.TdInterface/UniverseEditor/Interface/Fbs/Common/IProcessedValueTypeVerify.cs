using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006487 RID: 25735
	public static class IProcessedValueTypeVerify
	{
		// Token: 0x0602BBAE RID: 179118 RVA: 0x005F3162 File Offset: 0x005F1362
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
