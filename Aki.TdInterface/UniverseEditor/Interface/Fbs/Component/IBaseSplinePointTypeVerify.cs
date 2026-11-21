using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005426 RID: 21542
	public static class IBaseSplinePointTypeVerify
	{
		// Token: 0x06021C11 RID: 138257 RVA: 0x004A7548 File Offset: 0x004A5748
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

		// Token: 0x020082E0 RID: 33504
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144DA RID: 83162
			public static VerifyTableAction <0>__Verify;
		}
	}
}
