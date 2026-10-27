using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060D6 RID: 24790
	public static class IActorLookAtDataVerify
	{
		// Token: 0x0602A56D RID: 173421 RVA: 0x005D5EBE File Offset: 0x005D40BE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
