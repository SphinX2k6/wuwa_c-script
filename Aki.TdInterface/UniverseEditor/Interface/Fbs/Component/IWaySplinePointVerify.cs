using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006174 RID: 24948
	public static class IWaySplinePointVerify
	{
		// Token: 0x0602A630 RID: 173616 RVA: 0x005C8864 File Offset: 0x005C6A64
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

		// Token: 0x020084EC RID: 34028
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014846 RID: 84038
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014847 RID: 84039
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
