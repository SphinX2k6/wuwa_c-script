using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005047 RID: 20551
	public static class ICreateStageConfigVerify
	{
		// Token: 0x06020EEE RID: 134894 RVA: 0x004940DC File Offset: 0x004922DC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICreateStageConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICreateStageConfigVerify.<>O.<0>__Verify = new VerifyTableAction(ICreateBulletConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ICreateStageConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ICreateStageConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007ACD RID: 31437
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134CB RID: 79051
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040134CC RID: 79052
			public static VerifyTableAction <1>__Verify;
		}
	}
}
