using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004678 RID: 18040
	public static class ITrackTargetVerify
	{
		// Token: 0x0601A7B9 RID: 108473 RVA: 0x003C515C File Offset: 0x003C335C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ITrackTargetVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITrackTargetVerify.<>O.<0>__Verify = new VerifyUnionAction(TTrackTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false))
				{
					short offsetId = 14;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITrackTargetVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITrackTargetVerify.<>O.<1>__Verify = new VerifyTableAction(IZaxisViewRangeVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
					{
						short offsetId2 = 18;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ITrackTargetVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ITrackTargetVerify.<>O.<2>__Verify = new VerifyTableAction(ITrackEffectAutoChangeVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId2, verifyAction3, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x020081BE RID: 33214
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014352 RID: 82770
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04014353 RID: 82771
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04014354 RID: 82772
			public static VerifyTableAction <2>__Verify;
		}
	}
}
