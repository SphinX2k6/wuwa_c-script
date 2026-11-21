using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061DC RID: 25052
	public static class IWuWaGoLevelDataVerify
	{
		// Token: 0x0602A9AC RID: 174508 RVA: 0x005CF260 File Offset: 0x005CD460
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IWuWaGoLevelDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWuWaGoLevelDataVerify.<>O.<0>__Verify = new VerifyTableAction(IWuWaGoGridDataVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IWuWaGoLevelDataVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IWuWaGoLevelDataVerify.<>O.<1>__Verify = new VerifyTableAction(IWuWaGoRoleInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020084F9 RID: 34041
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014858 RID: 84056
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014859 RID: 84057
			public static VerifyTableAction <1>__Verify;
		}
	}
}
