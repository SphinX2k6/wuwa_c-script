using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004ECA RID: 20170
	public static class IAttributeComponentVerify
	{
		// Token: 0x0601FCA2 RID: 130210 RVA: 0x0046CBAC File Offset: 0x0046ADAC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 20, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 22, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 24, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 26, 1UL, 1UL, false))
			{
				short offsetId = 28;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAttributeComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAttributeComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IFightMusicsSwitchByTagListVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 30, false) && verifier.VerifyField(tablePos, 32, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 34, 8UL, false) && verifier.VerifyField(tablePos, 36, 1UL, 1UL, false))
				{
					short typeIdVOffset = 36;
					short valueVOffset = 38;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IAttributeComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IAttributeComponentVerify.<>O.<1>__Verify = new VerifyUnionAction(TWorldLevelBonusVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false) && verifier.VerifyField(tablePos, 40, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007A83 RID: 31363
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013455 RID: 78933
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013456 RID: 78934
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
