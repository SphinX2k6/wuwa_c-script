using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A46 RID: 23110
	public static class ILevelAIBehaviourBaseVerify
	{
		// Token: 0x06025CC1 RID: 154817 RVA: 0x0052E7DA File Offset: 0x0052C9DA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
