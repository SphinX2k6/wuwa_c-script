using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EDC RID: 24284
	public static class ISceneItemPatrolVerify
	{
		// Token: 0x06028B61 RID: 166753 RVA: 0x00590914 File Offset: 0x0058EB14
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISceneItemPatrolVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISceneItemPatrolVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ISceneItemPatrolVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ISceneItemPatrolVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
					{
						short offsetId3 = 12;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ISceneItemPatrolVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (ISceneItemPatrolVerify.<>O.<1>__Verify = new VerifyTableAction(ISceneItemAiPatrolByGameTimeVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0200848F RID: 33935
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147A3 RID: 83875
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040147A4 RID: 83876
			public static VerifyTableAction <1>__Verify;
		}
	}
}
