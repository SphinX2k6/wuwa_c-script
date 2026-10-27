using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054C0 RID: 21696
	public static class ILevelAIBehaviourBaseVerify
	{
		// Token: 0x06023C09 RID: 146441 RVA: 0x004F1766 File Offset: 0x004EF966
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
