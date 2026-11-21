using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005534 RID: 21812
	public static class ICommonSplinePointVerify
	{
		// Token: 0x060227F0 RID: 141296 RVA: 0x004C0760 File Offset: 0x004BE960
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICommonSplinePointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICommonSplinePointVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ICommonSplinePointVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ICommonSplinePointVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 8;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ICommonSplinePointVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (ICommonSplinePointVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
						{
							short offsetId4 = 12;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ICommonSplinePointVerify.<>O.<0>__Verify) == null)
							{
								verifyAction4 = (ICommonSplinePointVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02008311 RID: 33553
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014523 RID: 83235
			public static VerifyTableAction <0>__Verify;
		}
	}
}
