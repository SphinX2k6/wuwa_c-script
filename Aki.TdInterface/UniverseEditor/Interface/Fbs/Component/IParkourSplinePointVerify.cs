using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C5C RID: 23644
	public static class IParkourSplinePointVerify
	{
		// Token: 0x06027392 RID: 160658 RVA: 0x0055F72C File Offset: 0x0055D92C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IParkourSplinePointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IParkourSplinePointVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IParkourSplinePointVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IParkourSplinePointVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 8;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IParkourSplinePointVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (IParkourSplinePointVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
						{
							short offsetId4 = 12;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IParkourSplinePointVerify.<>O.<0>__Verify) == null)
							{
								verifyAction4 = (IParkourSplinePointVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 8UL, 8UL, false))
							{
								short offsetId5 = 20;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = IParkourSplinePointVerify.<>O.<1>__Verify) == null)
								{
									verifyAction5 = (IParkourSplinePointVerify.<>O.<1>__Verify = new VerifyTableAction(IPointGroupVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId5, verifyAction5, false) && verifier.VerifyString(tablePos, 22, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false))
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

		// Token: 0x02008428 RID: 33832
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014706 RID: 83718
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014707 RID: 83719
			public static VerifyTableAction <1>__Verify;
		}
	}
}
