using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200540F RID: 21519
	public static class IInhaledItemComponentVerify
	{
		// Token: 0x0602358A RID: 144778 RVA: 0x004E4724 File Offset: 0x004E2924
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IInhaledItemComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IInhaledItemComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IInhaledPerformanceVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					short typeIdVOffset = 12;
					short valueVOffset = 14;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IInhaledItemComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IInhaledItemComponentVerify.<>O.<1>__Verify = new VerifyUnionAction(TInhaledPerResultTypeVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007B67 RID: 31591
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040135CA RID: 79306
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040135CB RID: 79307
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
