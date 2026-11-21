using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EB5 RID: 24245
	public static class ISceneBulletGroupVerify
	{
		// Token: 0x06028A0F RID: 166415 RVA: 0x0058E03C File Offset: 0x0058C23C
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

		// Token: 0x02008488 RID: 33928
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014799 RID: 83865
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401479A RID: 83866
			public static VerifyTableAction <1>__Verify;
		}
	}
}
