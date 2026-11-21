using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BFC RID: 23548
	public static class INpcStandbyShowFinitelyVerify
	{
		// Token: 0x06026E4F RID: 159311 RVA: 0x00552F44 File Offset: 0x00551144
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = INpcStandbyShowFinitelyVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INpcStandbyShowFinitelyVerify.<>O.<0>__Verify = new VerifyTableAction(INpcLookAtConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = INpcStandbyShowFinitelyVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (INpcStandbyShowFinitelyVerify.<>O.<1>__Verify = new VerifyTableAction(INpcStandbyShowFinitelyInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008412 RID: 33810
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040146E3 RID: 83683
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040146E4 RID: 83684
			public static VerifyTableAction <1>__Verify;
		}
	}
}
