using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067C5 RID: 26565
	public static class IAdjustFixedLookAtTargetRangeEntityVerify
	{
		// Token: 0x0602D420 RID: 185376 RVA: 0x00631720 File Offset: 0x0062F920
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAdjustFixedLookAtTargetRangeEntityVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAdjustFixedLookAtTargetRangeEntityVerify.<>O.<0>__Verify = new VerifyTableAction(IMovingCameraTimeParamsVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IAdjustFixedLookAtTargetRangeEntityVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IAdjustFixedLookAtTargetRangeEntityVerify.<>O.<1>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 12;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IAdjustFixedLookAtTargetRangeEntityVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IAdjustFixedLookAtTargetRangeEntityVerify.<>O.<2>__Verify = new VerifyTableAction(ICutCameraConfigVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02008559 RID: 34137
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040148DC RID: 84188
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040148DD RID: 84189
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040148DE RID: 84190
			public static VerifyTableAction <2>__Verify;
		}
	}
}
