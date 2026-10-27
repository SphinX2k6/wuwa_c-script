using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067B5 RID: 26549
	public static class IFireBulletEffectVerify
	{
		// Token: 0x0602E342 RID: 189250 RVA: 0x0064F384 File Offset: 0x0064D584
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
