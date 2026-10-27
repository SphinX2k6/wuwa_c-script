using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050D7 RID: 20695
	public static class IDynamicBulletConfigVerify
	{
		// Token: 0x060214C2 RID: 136386 RVA: 0x0049FCA5 File Offset: 0x0049DEA5
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
