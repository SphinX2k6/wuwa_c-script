using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CB0 RID: 27824
	public static class IPhoneSystemInteractBaseVerify
	{
		// Token: 0x0603108C RID: 200844 RVA: 0x006A7C0A File Offset: 0x006A5E0A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
