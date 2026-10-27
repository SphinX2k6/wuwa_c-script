using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072D3 RID: 29395
	public static class ITalkItemAvgRoleConfigVerify
	{
		// Token: 0x06034806 RID: 215046 RVA: 0x00715444 File Offset: 0x00713644
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
