using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A6C RID: 31340
	public static class ITalkBackgroundCleanVerify
	{
		// Token: 0x060373BA RID: 226234 RVA: 0x00760712 File Offset: 0x0075E912
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
