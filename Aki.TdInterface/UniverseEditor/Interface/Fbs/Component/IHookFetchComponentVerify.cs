using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200593B RID: 22843
	public static class IHookFetchComponentVerify
	{
		// Token: 0x0602529F RID: 152223 RVA: 0x0051989C File Offset: 0x00517A9C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IHookFetchComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IHookFetchComponentVerify.<>O.<0>__Verify = new VerifyTableAction(ISphereTriggerShapeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IHookFetchComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IHookFetchComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IHookFetchMoveUniformVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 12;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IHookFetchComponentVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IHookFetchComponentVerify.<>O.<2>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 14;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IHookFetchComponentVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IHookFetchComponentVerify.<>O.<3>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
							}
							if (verifier.VerifyVectorOfTables(tablePos, offsetId4, verifyAction4, false))
							{
								short offsetId5 = 16;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = IHookFetchComponentVerify.<>O.<3>__Verify) == null)
								{
									verifyAction5 = (IHookFetchComponentVerify.<>O.<3>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
								}
								if (verifier.VerifyVectorOfTables(tablePos, offsetId5, verifyAction5, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
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

		// Token: 0x020083BA RID: 33722
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014635 RID: 83509
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014636 RID: 83510
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04014637 RID: 83511
			public static VerifyTableAction <2>__Verify;

			// Token: 0x04014638 RID: 83512
			public static VerifyTableAction <3>__Verify;
		}
	}
}
