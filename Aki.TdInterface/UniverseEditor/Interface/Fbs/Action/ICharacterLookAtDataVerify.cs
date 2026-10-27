using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200633F RID: 25407
	public static class ICharacterLookAtDataVerify
	{
		// Token: 0x0602BF31 RID: 180017 RVA: 0x0060A6B6 File Offset: 0x006088B6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
