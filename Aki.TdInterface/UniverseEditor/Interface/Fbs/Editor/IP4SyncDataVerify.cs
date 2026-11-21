using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CF9 RID: 19705
	public static class IP4SyncDataVerify
	{
		// Token: 0x0601E7DA RID: 124890 RVA: 0x004452B2 File Offset: 0x004434B2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
