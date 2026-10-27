using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004910 RID: 18704
	public static class ILoopTeleportClientPlayEffectLogicVerify
	{
		// Token: 0x0601D3DB RID: 119771 RVA: 0x0041FEA4 File Offset: 0x0041E0A4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ILoopTeleportClientPlayEffectLogicVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILoopTeleportClientPlayEffectLogicVerify.<>O.<0>__Verify = new VerifyUnionAction(TLoopTeleportClientPlayEffectVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A1B RID: 31259
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133DC RID: 78812
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
