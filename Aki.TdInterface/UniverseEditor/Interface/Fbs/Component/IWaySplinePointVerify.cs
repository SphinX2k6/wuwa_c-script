using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B5E RID: 23390
	public static class IWaySplinePointVerify
	{
		// Token: 0x0602806C RID: 163948 RVA: 0x00580DD4 File Offset: 0x0057EFD4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IWaySplinePointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWaySplinePointVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IWaySplinePointVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IWaySplinePointVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 8;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IWaySplinePointVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (IWaySplinePointVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
						{
							short offsetId4 = 12;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IWaySplinePointVerify.<>O.<0>__Verify) == null)
							{
								verifyAction4 = (IWaySplinePointVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
							{
								short typeIdVOffset = 14;
								short valueVOffset = 16;
								VerifyUnionAction verifyAction5;
								if ((verifyAction5 = IWaySplinePointVerify.<>O.<1>__Verify) == null)
								{
									verifyAction5 = (IWaySplinePointVerify.<>O.<1>__Verify = new VerifyUnionAction(TWaySplinePointTypeVerify.Verify));
								}
								if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction5, false))
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

		// Token: 0x02007C7B RID: 31867
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137A0 RID: 79776
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040137A1 RID: 79777
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
