using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041C8 RID: 16840
	public static class IConditionReturnPosVerify
	{
		// Token: 0x060174C3 RID: 95427 RVA: 0x003536A4 File Offset: 0x003518A4
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

		// Token: 0x0200810D RID: 33037
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040141AD RID: 82349
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040141AE RID: 82350
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
