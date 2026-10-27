using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E5F RID: 15967
	public static class IFlipperConditionStepBaseVerify
	{
		// Token: 0x060167AB RID: 92075 RVA: 0x0033FF0A File Offset: 0x0033E10A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
