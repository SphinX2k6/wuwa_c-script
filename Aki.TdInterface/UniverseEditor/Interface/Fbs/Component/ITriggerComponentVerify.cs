using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060ED RID: 24813
	public static class ITriggerComponentVerify
	{
		// Token: 0x0602A0AD RID: 172205 RVA: 0x005BD278 File Offset: 0x005BB478
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITriggerComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITriggerComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityMatchVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
				{
					short offsetId2 = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITriggerComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITriggerComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 14;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ITriggerComponentVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ITriggerComponentVerify.<>O.<2>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 16;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ITriggerComponentVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (ITriggerComponentVerify.<>O.<3>__Verify = new VerifyTableAction(ITriggerExitConfigVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyVectorOfData(tablePos, 18, 1UL, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 26, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 28, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 30, 1UL, 1UL, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x020084DB RID: 34011
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401482B RID: 84011
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401482C RID: 84012
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401482D RID: 84013
			public static VerifyTableAction <2>__Verify;

			// Token: 0x0401482E RID: 84014
			public static VerifyTableAction <3>__Verify;
		}
	}
}
