using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A18 RID: 23064
	public static class ISwordRiderRailSplinePointVerify
	{
		// Token: 0x060272C0 RID: 160448 RVA: 0x00563774 File Offset: 0x00561974
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

		// Token: 0x02007C4E RID: 31822
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013748 RID: 79688
			public static VerifyTableAction <0>__Verify;
		}
	}
}
