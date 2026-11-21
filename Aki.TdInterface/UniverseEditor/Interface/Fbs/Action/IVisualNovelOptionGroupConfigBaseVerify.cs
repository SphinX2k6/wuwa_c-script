using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D84 RID: 32132
	public static class IVisualNovelOptionGroupConfigBaseVerify
	{
		// Token: 0x0603A00F RID: 237583 RVA: 0x007D1D46 File Offset: 0x007CFF46
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
