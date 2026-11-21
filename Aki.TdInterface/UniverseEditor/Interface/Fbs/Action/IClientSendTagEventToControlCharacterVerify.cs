using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A64 RID: 27236
	public static class IClientSendTagEventToControlCharacterVerify
	{
		// Token: 0x0602EBB8 RID: 191416 RVA: 0x0065EA0B File Offset: 0x0065CC0B
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfStrings(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
