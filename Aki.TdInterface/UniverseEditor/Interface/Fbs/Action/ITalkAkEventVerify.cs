using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007291 RID: 29329
	public static class ITalkAkEventVerify
	{
		// Token: 0x06034092 RID: 213138 RVA: 0x006FF096 File Offset: 0x006FD296
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
