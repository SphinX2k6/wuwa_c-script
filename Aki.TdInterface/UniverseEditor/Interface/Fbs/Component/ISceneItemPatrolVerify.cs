using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058CF RID: 22735
	public static class ISceneItemPatrolVerify
	{
		// Token: 0x060265FF RID: 157183 RVA: 0x00549DC8 File Offset: 0x00547FC8
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

		// Token: 0x02007C20 RID: 31776
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013701 RID: 79617
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013702 RID: 79618
			public static VerifyTableAction <1>__Verify;
		}
	}
}
