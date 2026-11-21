using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EE0 RID: 28384
	public static class IFollowShooterLeisureInteractTypeVerify
	{
		// Token: 0x060311C2 RID: 201154 RVA: 0x006A87FA File Offset: 0x006A69FA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
