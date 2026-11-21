using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007426 RID: 29734
	public static class IPhoneSystemInteractBaseVerify
	{
		// Token: 0x06034063 RID: 213091 RVA: 0x00702E3E File Offset: 0x0070103E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
