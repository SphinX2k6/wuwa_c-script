using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005499 RID: 21657
	public static class IItemFoundationTypeVerify
	{
		// Token: 0x06023A57 RID: 146007 RVA: 0x004EDB3E File Offset: 0x004EBD3E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
