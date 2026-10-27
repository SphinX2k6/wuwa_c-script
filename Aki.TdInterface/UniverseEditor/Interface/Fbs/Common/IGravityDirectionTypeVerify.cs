using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DFC RID: 24060
	public static class IGravityDirectionTypeVerify
	{
		// Token: 0x060292F3 RID: 168691 RVA: 0x005A67CE File Offset: 0x005A49CE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
