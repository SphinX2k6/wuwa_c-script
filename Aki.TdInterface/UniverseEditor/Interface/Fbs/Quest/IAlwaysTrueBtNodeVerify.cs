using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D00 RID: 15616
	public static class IAlwaysTrueBtNodeVerify
	{
		// Token: 0x060158A2 RID: 88226 RVA: 0x0031CCD8 File Offset: 0x0031AED8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 8, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAlwaysTrueBtNodeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAlwaysTrueBtNodeVerify.<>O.<0>__Verify = new VerifyTableAction(IFixProcessorVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
				{
					short typeIdVOffset = 16;
					short valueVOffset = 18;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IAlwaysTrueBtNodeVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IAlwaysTrueBtNodeVerify.<>O.<1>__Verify = new VerifyUnionAction(TBtNodeVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020078AF RID: 30895
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013123 RID: 78115
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013124 RID: 78116
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
