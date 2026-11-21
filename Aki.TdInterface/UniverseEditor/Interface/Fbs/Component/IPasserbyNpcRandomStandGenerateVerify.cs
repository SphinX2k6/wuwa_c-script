using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CAD RID: 23725
	public static class IPasserbyNpcRandomStandGenerateVerify
	{
		// Token: 0x060275DC RID: 161244 RVA: 0x0056387C File Offset: 0x00561A7C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPasserbyNpcRandomStandGenerateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPasserbyNpcRandomStandGenerateVerify.<>O.<0>__Verify = new VerifyTableAction(IPasserbyNpcSelfSpawnCenterPosVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IPasserbyNpcRandomStandGenerateVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IPasserbyNpcRandomStandGenerateVerify.<>O.<1>__Verify = new VerifyTableAction(IPasserbyNpcRandomGroupVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008433 RID: 33843
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014713 RID: 83731
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014714 RID: 83732
			public static VerifyTableAction <1>__Verify;
		}
	}
}
