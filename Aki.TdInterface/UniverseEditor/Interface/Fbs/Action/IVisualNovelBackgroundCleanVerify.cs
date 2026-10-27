using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007561 RID: 30049
	public static class IVisualNovelBackgroundCleanVerify
	{
		// Token: 0x06036AAB RID: 223915 RVA: 0x0076CA26 File Offset: 0x0076AC26
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
