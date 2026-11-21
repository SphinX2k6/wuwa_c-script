using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D63 RID: 32099
	public static class IVisualNovelCgCleanVerify
	{
		// Token: 0x06039F0B RID: 237323 RVA: 0x007D034A File Offset: 0x007CE54A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
