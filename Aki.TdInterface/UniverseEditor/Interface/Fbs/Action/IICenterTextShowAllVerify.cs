using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006941 RID: 26945
	public static class IICenterTextShowAllVerify
	{
		// Token: 0x0602F0CB RID: 192715 RVA: 0x00669D42 File Offset: 0x00667F42
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
