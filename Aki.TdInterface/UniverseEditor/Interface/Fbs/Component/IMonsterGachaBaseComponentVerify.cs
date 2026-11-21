using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B18 RID: 23320
	public static class IMonsterGachaBaseComponentVerify
	{
		// Token: 0x06026593 RID: 157075 RVA: 0x00540F58 File Offset: 0x0053F158
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMonsterGachaBaseComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMonsterGachaBaseComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IMonsterGachaSlotVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IMonsterGachaBaseComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IMonsterGachaBaseComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IMonsterFormationVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020083F5 RID: 33781
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040146AE RID: 83630
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040146AF RID: 83631
			public static VerifyTableAction <1>__Verify;
		}
	}
}
