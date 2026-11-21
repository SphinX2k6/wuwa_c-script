using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070B1 RID: 28849
	public static class ILiftMoveTypeVerify
	{
		// Token: 0x06032188 RID: 205192 RVA: 0x006C7C0E File Offset: 0x006C5E0E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
