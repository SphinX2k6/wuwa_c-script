using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E47 RID: 24135
	public static class IProcessedValueTypeVerify
	{
		// Token: 0x06029512 RID: 169234 RVA: 0x005AA2BA File Offset: 0x005A84BA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
