using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BB8 RID: 19384
	public static class ICompareMinAlertValueVerify
	{
		// Token: 0x0601E937 RID: 125239 RVA: 0x00446C86 File Offset: 0x00444E86
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
