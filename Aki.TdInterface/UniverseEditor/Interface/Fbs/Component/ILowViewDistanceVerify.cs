using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200551D RID: 21789
	public static class ILowViewDistanceVerify
	{
		// Token: 0x06023FCE RID: 147406 RVA: 0x004F92C2 File Offset: 0x004F74C2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
