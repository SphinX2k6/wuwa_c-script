using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EF4 RID: 20212
	public static class IBaseSplinePointTypeVerify
	{
		// Token: 0x0601FEA1 RID: 130721 RVA: 0x004711B4 File Offset: 0x0046F3B4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IBaseSplinePointTypeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBaseSplinePointTypeVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IBaseSplinePointTypeVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IBaseSplinePointTypeVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 8;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IBaseSplinePointTypeVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (IBaseSplinePointTypeVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
						{
							short offsetId4 = 12;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IBaseSplinePointTypeVerify.<>O.<0>__Verify) == null)
							{
								verifyAction4 = (IBaseSplinePointTypeVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
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

		// Token: 0x02007A89 RID: 31369
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013463 RID: 78947
			public static VerifyTableAction <0>__Verify;
		}
	}
}
