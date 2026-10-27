using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050A7 RID: 20647
	public static class IDollGrabShowcaseComponentVerify
	{
		// Token: 0x060212B2 RID: 135858 RVA: 0x0049BCEC File Offset: 0x00499EEC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDollGrabShowcaseComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDollGrabShowcaseComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IDollGrabShowcaseDollCameraConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IDollGrabShowcaseComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IDollGrabShowcaseComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IShowcaseDeliveryRewardVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007ADA RID: 31450
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134E5 RID: 79077
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040134E6 RID: 79078
			public static VerifyTableAction <1>__Verify;
		}
	}
}
