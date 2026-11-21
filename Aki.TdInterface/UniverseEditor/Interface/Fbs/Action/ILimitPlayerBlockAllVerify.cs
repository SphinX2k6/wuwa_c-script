using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070C6 RID: 28870
	public static class ILimitPlayerBlockAllVerify
	{
		// Token: 0x06032220 RID: 205344 RVA: 0x006C8A5A File Offset: 0x006C6C5A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
