using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070E7 RID: 28903
	public static class IShowMessageVerify
	{
		// Token: 0x0603335A RID: 209754 RVA: 0x006E72D5 File Offset: 0x006E54D5
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
