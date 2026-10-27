using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DB1 RID: 15793
	public static class IConditionReturnPosVerify
	{
		// Token: 0x06015F8B RID: 89995 RVA: 0x0032C378 File Offset: 0x0032A578
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IConditionReturnPosVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IConditionReturnPosVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
				{
					short typeIdVOffset = 6;
					short valueVOffset = 8;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IConditionReturnPosVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IConditionReturnPosVerify.<>O.<1>__Verify = new VerifyUnionAction(TFastReturnPosVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020078C9 RID: 30921
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013151 RID: 78161
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013152 RID: 78162
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
