using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A7E RID: 27262
	public static class IMechBehaviorConfigVerify
	{
		// Token: 0x0602FC44 RID: 195652 RVA: 0x0067FF40 File Offset: 0x0067E140
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IMechBehaviorConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMechBehaviorConfigVerify.<>O.<0>__Verify = new VerifyUnionAction(TMechStuntConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IMechBehaviorConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IMechBehaviorConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007DA3 RID: 32163
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401393B RID: 80187
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x0401393C RID: 80188
			public static VerifyTableAction <1>__Verify;
		}
	}
}
