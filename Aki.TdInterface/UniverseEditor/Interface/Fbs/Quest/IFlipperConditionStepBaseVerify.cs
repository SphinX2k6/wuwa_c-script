using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200429A RID: 17050
	public static class IFlipperConditionStepBaseVerify
	{
		// Token: 0x06017DD2 RID: 97746 RVA: 0x00368A3A File Offset: 0x00366C3A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
