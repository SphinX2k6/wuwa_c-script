using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007297 RID: 29335
	public static class ITalkBackgroundCleanVerify
	{
		// Token: 0x060340B6 RID: 213174 RVA: 0x006FF376 File Offset: 0x006FD576
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
