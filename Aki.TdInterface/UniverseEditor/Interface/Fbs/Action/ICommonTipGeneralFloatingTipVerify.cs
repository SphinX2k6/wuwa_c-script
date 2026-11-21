using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B08 RID: 27400
	public static class ICommonTipGeneralFloatingTipVerify
	{
		// Token: 0x0602F1BF RID: 192959 RVA: 0x0066CC2B File Offset: 0x0066AE2B
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
