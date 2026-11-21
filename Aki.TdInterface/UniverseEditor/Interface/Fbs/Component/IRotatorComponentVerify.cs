using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E9D RID: 24221
	public static class IRotatorComponentVerify
	{
		// Token: 0x060288E9 RID: 166121 RVA: 0x0058B690 File Offset: 0x00589890
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyString(tablePos, 8, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRotatorComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRotatorComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IRotatorComponentVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IRotatorComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 14;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IRotatorComponentVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (IRotatorComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 16;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IRotatorComponentVerify.<>O.<0>__Verify) == null)
							{
								verifyAction4 = (IRotatorComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 20, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false))
							{
								short offsetId5 = 24;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = IRotatorComponentVerify.<>O.<1>__Verify) == null)
								{
									verifyAction5 = (IRotatorComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IEventRotatorVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId5, verifyAction5, false) && verifier.VerifyField(tablePos, 26, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 28, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 30, 1UL, 1UL, false))
								{
									return verifier.VerifyTableEnd(tablePos);
								}
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02008483 RID: 33923
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014790 RID: 83856
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014791 RID: 83857
			public static VerifyTableAction <1>__Verify;
		}
	}
}
