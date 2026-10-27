using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062B9 RID: 25273
	public static class ICatapultParamVerify
	{
		// Token: 0x0602BADC RID: 178908 RVA: 0x006030E0 File Offset: 0x006012E0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICatapultParamVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICatapultParamVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ICatapultParamVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ICatapultParamVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007D09 RID: 32009
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401386C RID: 79980
			public static VerifyTableAction <0>__Verify;
		}
	}
}
