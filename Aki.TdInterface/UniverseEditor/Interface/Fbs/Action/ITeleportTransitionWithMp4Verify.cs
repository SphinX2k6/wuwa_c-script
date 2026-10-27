using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073BD RID: 29629
	public static class ITeleportTransitionWithMp4Verify
	{
		// Token: 0x06035CD9 RID: 220377 RVA: 0x00752A28 File Offset: 0x00750C28
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 2UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
