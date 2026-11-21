using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067BF RID: 26559
	public static class IAdjustFixedLookAtTargetBaseVerify
	{
		// Token: 0x0602D3F2 RID: 185330 RVA: 0x00631182 File Offset: 0x0062F382
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
