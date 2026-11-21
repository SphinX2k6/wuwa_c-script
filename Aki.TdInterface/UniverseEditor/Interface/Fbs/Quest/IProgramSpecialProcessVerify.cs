using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043F9 RID: 17401
	public static class IProgramSpecialProcessVerify
	{
		// Token: 0x06018BC0 RID: 101312 RVA: 0x003867A0 File Offset: 0x003849A0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IProgramSpecialProcessVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IProgramSpecialProcessVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IProgramSpecialProcessVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IProgramSpecialProcessVerify.<>O.<1>__Verify = new VerifyTableAction(ILowMemorySceneSwitchVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008167 RID: 33127
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401426F RID: 82543
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014270 RID: 82544
			public static VerifyTableAction <1>__Verify;
		}
	}
}
