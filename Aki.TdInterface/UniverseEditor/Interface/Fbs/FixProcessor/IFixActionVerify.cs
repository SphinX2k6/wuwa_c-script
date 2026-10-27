using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x02004756 RID: 18262
	public static class IFixActionVerify
	{
		// Token: 0x0601C1B6 RID: 115126 RVA: 0x003FB744 File Offset: 0x003F9944
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFixActionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFixActionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IFixActionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IFixActionVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020079E9 RID: 31209
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013394 RID: 78740
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013395 RID: 78741
			public static VerifyTableAction <1>__Verify;
		}
	}
}
