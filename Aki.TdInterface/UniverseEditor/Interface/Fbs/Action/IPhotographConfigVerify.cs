using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007438 RID: 29752
	public static class IPhotographConfigVerify
	{
		// Token: 0x060340ED RID: 213229 RVA: 0x00703E20 File Offset: 0x00702020
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPhotographConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPhotographConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IPhotographPlayerPerformVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IPhotographConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IPhotographConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IPhotographCameraParamsVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008675 RID: 34421
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A5F RID: 84575
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014A60 RID: 84576
			public static VerifyTableAction <1>__Verify;
		}
	}
}
