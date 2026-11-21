using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063D9 RID: 25561
	public static class IEaseCurveTypeVerify
	{
		// Token: 0x0602B6BD RID: 177853 RVA: 0x005EABAE File Offset: 0x005E8DAE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
