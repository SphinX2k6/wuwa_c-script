using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200717A RID: 29050
	public static class ISpecificScanEffectVerify
	{
		// Token: 0x06033816 RID: 210966 RVA: 0x006F02BA File Offset: 0x006EE4BA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
