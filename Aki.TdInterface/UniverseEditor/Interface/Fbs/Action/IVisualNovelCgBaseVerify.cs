using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007567 RID: 30055
	public static class IVisualNovelCgBaseVerify
	{
		// Token: 0x06036AD3 RID: 223955 RVA: 0x0076CD9E File Offset: 0x0076AF9E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
