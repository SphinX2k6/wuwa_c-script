using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D5D RID: 32093
	public static class IVisualNovelCgBaseVerify
	{
		// Token: 0x06039EE9 RID: 237289 RVA: 0x007D0046 File Offset: 0x007CE246
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
