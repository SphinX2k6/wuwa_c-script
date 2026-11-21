using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006025 RID: 24613
	public static class ISwordRiderRailSplinePointVerify
	{
		// Token: 0x06029838 RID: 170040 RVA: 0x005AA738 File Offset: 0x005A8938
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISwordRiderRailSplinePointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISwordRiderRailSplinePointVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ISwordRiderRailSplinePointVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ISwordRiderRailSplinePointVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 8;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ISwordRiderRailSplinePointVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (ISwordRiderRailSplinePointVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
						{
							short offsetId4 = 12;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ISwordRiderRailSplinePointVerify.<>O.<0>__Verify) == null)
							{
								verifyAction4 = (ISwordRiderRailSplinePointVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x020084BD RID: 33981
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147EC RID: 83948
			public static VerifyTableAction <0>__Verify;
		}
	}
}
