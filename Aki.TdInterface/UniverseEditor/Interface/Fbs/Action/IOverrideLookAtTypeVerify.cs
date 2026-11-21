using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073C0 RID: 29632
	public static class IOverrideLookAtTypeVerify
	{
		// Token: 0x06033D53 RID: 212307 RVA: 0x006FDBDA File Offset: 0x006FBDDA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
