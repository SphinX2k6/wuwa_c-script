using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006466 RID: 25702
	public static class IOutAreaBorderTypeVerify
	{
		// Token: 0x0602BAD7 RID: 178903 RVA: 0x005F1C36 File Offset: 0x005EFE36
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
