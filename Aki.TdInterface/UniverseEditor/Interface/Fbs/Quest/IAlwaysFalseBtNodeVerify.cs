using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003CFD RID: 15613
	public static class IAlwaysFalseBtNodeVerify
	{
		// Token: 0x06015862 RID: 88162 RVA: 0x0031C0E8 File Offset: 0x0031A2E8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 8, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAlwaysFalseBtNodeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAlwaysFalseBtNodeVerify.<>O.<0>__Verify = new VerifyTableAction(IFixProcessorVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
				{
					short typeIdVOffset = 16;
					short valueVOffset = 18;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IAlwaysFalseBtNodeVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IAlwaysFalseBtNodeVerify.<>O.<1>__Verify = new VerifyUnionAction(TBtNodeVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020078AE RID: 30894
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013121 RID: 78113
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013122 RID: 78114
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
