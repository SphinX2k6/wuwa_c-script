using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056DC RID: 22236
	public static class IPasserbyNpcSpawnComponentVerify
	{
		// Token: 0x06025269 RID: 152169 RVA: 0x00520C8C File Offset: 0x0051EE8C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPasserbyNpcSpawnComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPasserbyNpcSpawnComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IPasserbyNpcSplineMoveVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IPasserbyNpcSpawnComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IPasserbyNpcSpawnComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IPasserbyNpcFixIntervalSpawnVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IPasserbyNpcSpawnComponentVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IPasserbyNpcSpawnComponentVerify.<>O.<2>__Verify = new VerifyTableAction(IPasserbyNpcTemplateSourceVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyString(tablePos, 12, false))
						{
							short offsetId4 = 14;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IPasserbyNpcSpawnComponentVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IPasserbyNpcSpawnComponentVerify.<>O.<3>__Verify = new VerifyTableAction(IPasserbyNpcDeviceGradeConfigVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false))
							{
								short offsetId5 = 16;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = IPasserbyNpcSpawnComponentVerify.<>O.<4>__Verify) == null)
								{
									verifyAction5 = (IPasserbyNpcSpawnComponentVerify.<>O.<4>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId5, verifyAction5, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
								{
									return verifier.VerifyTableEnd(tablePos);
								}
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007BC9 RID: 31689
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401367C RID: 79484
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401367D RID: 79485
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401367E RID: 79486
			public static VerifyTableAction <2>__Verify;

			// Token: 0x0401367F RID: 79487
			public static VerifyTableAction <3>__Verify;

			// Token: 0x04013680 RID: 79488
			public static VerifyTableAction <4>__Verify;
		}
	}
}
