using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200557A RID: 21882
	public static class IMonsterGachaBaseComponentVerify
	{
		// Token: 0x06024386 RID: 148358 RVA: 0x005009E0 File Offset: 0x004FEBE0
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

		// Token: 0x02007B93 RID: 31635
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401361F RID: 79391
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013620 RID: 79392
			public static VerifyTableAction <1>__Verify;
		}
	}
}
