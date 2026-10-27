using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075D6 RID: 30166
	public static class IVisualNovelRoleConfigVerify
	{
		// Token: 0x06036F41 RID: 225089 RVA: 0x00775418 File Offset: 0x00773618
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
