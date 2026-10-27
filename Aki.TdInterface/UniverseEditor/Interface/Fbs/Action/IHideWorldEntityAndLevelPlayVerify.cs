using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200690E RID: 26894
	public static class IHideWorldEntityAndLevelPlayVerify
	{
		// Token: 0x0602EEF7 RID: 192247 RVA: 0x00666ABD File Offset: 0x00664CBD
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
