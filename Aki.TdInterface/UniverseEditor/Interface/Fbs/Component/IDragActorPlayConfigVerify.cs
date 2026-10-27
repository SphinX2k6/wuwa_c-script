using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050B9 RID: 20665
	public static class IDragActorPlayConfigVerify
	{
		// Token: 0x06021392 RID: 136082 RVA: 0x0049D948 File Offset: 0x0049BB48
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDragActorPlayConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDragActorPlayConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IActorRefVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false))
				{
					short offsetId2 = 20;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IDragActorPlayConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IDragActorPlayConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IDragActorPlayKeyPointConfigVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyString(tablePos, 22, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false))
					{
						short offsetId3 = 26;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IDragActorPlayConfigVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IDragActorPlayConfigVerify.<>O.<2>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 28, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 30, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007ADE RID: 31454
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134EB RID: 79083
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040134EC RID: 79084
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040134ED RID: 79085
			public static VerifyTableAction <2>__Verify;
		}
	}
}
