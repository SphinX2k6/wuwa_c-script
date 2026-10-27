using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003ED4 RID: 16084
	public static class IKurotatoConditionStepBaseVerify
	{
		// Token: 0x06016C00 RID: 93184 RVA: 0x00348B66 File Offset: 0x00346D66
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
