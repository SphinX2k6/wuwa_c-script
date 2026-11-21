using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004291 RID: 17041
	public static class IFirstPersonTurretGamePlayConfigVerify
	{
		// Token: 0x06017D87 RID: 97671 RVA: 0x0036808A File Offset: 0x0036628A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
