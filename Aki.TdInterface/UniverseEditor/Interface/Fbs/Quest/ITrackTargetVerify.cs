using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200421C RID: 16924
	public static class ITrackTargetVerify
	{
		// Token: 0x0601904D RID: 102477 RVA: 0x00399A84 File Offset: 0x00397C84
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

		// Token: 0x02007975 RID: 31093
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040132EB RID: 78571
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x040132EC RID: 78572
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040132ED RID: 78573
			public static VerifyTableAction <2>__Verify;
		}
	}
}
