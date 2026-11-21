using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063EB RID: 25579
	public static class IFollowShooterAbilityTypeVerify
	{
		// Token: 0x0602B751 RID: 178001 RVA: 0x005EBB86 File Offset: 0x005E9D86
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
