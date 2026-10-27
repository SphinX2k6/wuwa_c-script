using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D7F RID: 28031
	public static class IPostAkEventTypeVerify
	{
		// Token: 0x06031847 RID: 202823 RVA: 0x006B65FA File Offset: 0x006B47FA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
