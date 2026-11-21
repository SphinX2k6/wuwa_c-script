using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051C2 RID: 20930
	public static class ISkillReadyTypeVerify
	{
		// Token: 0x06020F3C RID: 134972 RVA: 0x0048E87A File Offset: 0x0048CA7A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
