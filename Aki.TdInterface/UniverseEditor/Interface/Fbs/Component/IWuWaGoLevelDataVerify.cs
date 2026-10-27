using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BC6 RID: 23494
	public static class IWuWaGoLevelDataVerify
	{
		// Token: 0x060283E8 RID: 164840 RVA: 0x005877D0 File Offset: 0x005859D0
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

		// Token: 0x02007C88 RID: 31880
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137B2 RID: 79794
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040137B3 RID: 79795
			public static VerifyTableAction <1>__Verify;
		}
	}
}
