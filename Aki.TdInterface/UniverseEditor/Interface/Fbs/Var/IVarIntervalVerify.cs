using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B0A RID: 15114
	public static class IVarIntervalVerify
	{
		// Token: 0x060149FC RID: 84476 RVA: 0x00300B84 File Offset: 0x002FED84
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IVarIntervalVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVarIntervalVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 8;
					short valueVOffset2 = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IVarIntervalVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IVarIntervalVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007884 RID: 30852
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040130ED RID: 78061
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
