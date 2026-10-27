using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FD5 RID: 20437
	public static class ICommonSplinePointVerify
	{
		// Token: 0x060208D4 RID: 133332 RVA: 0x00486DA0 File Offset: 0x00484FA0
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

		// Token: 0x02007AB7 RID: 31415
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134A5 RID: 79013
			public static VerifyTableAction <0>__Verify;
		}
	}
}
