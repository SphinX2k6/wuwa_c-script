using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DF0 RID: 24048
	public static class IGiantTriggerTypeVerify
	{
		// Token: 0x060292A9 RID: 168617 RVA: 0x005A6152 File Offset: 0x005A4352
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
