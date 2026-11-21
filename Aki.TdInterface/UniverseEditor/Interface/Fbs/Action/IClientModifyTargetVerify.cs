using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A58 RID: 27224
	public static class IClientModifyTargetVerify
	{
		// Token: 0x0602EB3C RID: 191292 RVA: 0x0065D986 File Offset: 0x0065BB86
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
