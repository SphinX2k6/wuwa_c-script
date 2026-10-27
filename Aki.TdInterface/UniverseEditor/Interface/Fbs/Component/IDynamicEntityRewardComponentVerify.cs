using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050DD RID: 20701
	public static class IDynamicEntityRewardComponentVerify
	{
		// Token: 0x06021534 RID: 136500 RVA: 0x004A0DB8 File Offset: 0x0049EFB8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDynamicEntityRewardComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDynamicEntityRewardComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IDynamicTrafficRewardVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 8, 1UL, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IDynamicEntityRewardComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IDynamicEntityRewardComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007AE2 RID: 31458
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134F4 RID: 79092
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040134F5 RID: 79093
			public static VerifyTableAction <1>__Verify;
		}
	}
}
