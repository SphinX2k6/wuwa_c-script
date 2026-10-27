using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007552 RID: 30034
	public static class IVisualNovelActivityActionConfigBaseVerify
	{
		// Token: 0x06036A57 RID: 223831 RVA: 0x0076C2F2 File Offset: 0x0076A4F2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
