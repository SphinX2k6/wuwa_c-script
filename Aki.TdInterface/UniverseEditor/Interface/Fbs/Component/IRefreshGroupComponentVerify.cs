using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200582B RID: 22571
	public static class IRefreshGroupComponentVerify
	{
		// Token: 0x06025F72 RID: 155506 RVA: 0x0053C0B4 File Offset: 0x0053A2B4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IRefreshGroupComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRefreshGroupComponentVerify.<>O.<0>__Verify = new VerifyUnionAction(TRefreshContentVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 12;
					short valueVOffset2 = 14;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IRefreshGroupComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IRefreshGroupComponentVerify.<>O.<1>__Verify = new VerifyUnionAction(TRefreshRuleVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false))
					{
						short offsetId = 16;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IRefreshGroupComponentVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IRefreshGroupComponentVerify.<>O.<2>__Verify = new VerifyTableAction(IStateChangeConfigVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId, verifyAction3, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007C04 RID: 31748
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136D5 RID: 79573
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x040136D6 RID: 79574
			public static VerifyUnionAction <1>__Verify;

			// Token: 0x040136D7 RID: 79575
			public static VerifyTableAction <2>__Verify;
		}
	}
}
