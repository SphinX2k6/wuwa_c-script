using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006488 RID: 25736
	public static class ICommonTip2TypeVerify
	{
		// Token: 0x0602C9A3 RID: 182691 RVA: 0x00620172 File Offset: 0x0061E372
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
