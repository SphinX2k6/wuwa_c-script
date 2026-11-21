using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004DAB RID: 19883
	public static class ILoopTeleportClientPlayEffectLogicVerify
	{
		// Token: 0x0601ED74 RID: 126324 RVA: 0x0044F604 File Offset: 0x0044D804
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

		// Token: 0x02008269 RID: 33385
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014448 RID: 83016
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
