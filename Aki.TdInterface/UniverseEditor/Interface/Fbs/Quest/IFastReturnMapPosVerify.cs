using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200425E RID: 16990
	public static class IFastReturnMapPosVerify
	{
		// Token: 0x06017AD7 RID: 96983 RVA: 0x00360C54 File Offset: 0x0035EE54
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFastReturnMapPosVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFastReturnMapPosVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset = 8;
					short valueVOffset = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IFastReturnMapPosVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IFastReturnMapPosVerify.<>O.<1>__Verify = new VerifyUnionAction(TFastReturnPosVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false))
					{
						short offsetId2 = 12;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IFastReturnMapPosVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IFastReturnMapPosVerify.<>O.<2>__Verify = new VerifyTableAction(IConditionReturnPosVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction3, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02008120 RID: 33056
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040141DD RID: 82397
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040141DE RID: 82398
			public static VerifyUnionAction <1>__Verify;

			// Token: 0x040141DF RID: 82399
			public static VerifyTableAction <2>__Verify;
		}
	}
}
