using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E23 RID: 15907
	public static class IFastReturnMapPosVerify
	{
		// Token: 0x060164AA RID: 91306 RVA: 0x0033805C File Offset: 0x0033625C
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

		// Token: 0x020078DA RID: 30938
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401317F RID: 78207
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013180 RID: 78208
			public static VerifyUnionAction <1>__Verify;

			// Token: 0x04013181 RID: 78209
			public static VerifyTableAction <2>__Verify;
		}
	}
}
