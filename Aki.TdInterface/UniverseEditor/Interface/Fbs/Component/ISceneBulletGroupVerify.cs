using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058A8 RID: 22696
	public static class ISceneBulletGroupVerify
	{
		// Token: 0x060264AD RID: 156845 RVA: 0x005474F0 File Offset: 0x005456F0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 8UL, 8UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISceneBulletGroupVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISceneBulletGroupVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ISceneBulletGroupVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ISceneBulletGroupVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 12;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ISceneBulletGroupVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (ISceneBulletGroupVerify.<>O.<1>__Verify = new VerifyTableAction(ITrafficBulletLogicVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007C19 RID: 31769
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136F7 RID: 79607
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040136F8 RID: 79608
			public static VerifyTableAction <1>__Verify;
		}
	}
}
