using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A0A RID: 23050
	public static class IIntervalSplineSpawnVerify
	{
		// Token: 0x06025A68 RID: 154216 RVA: 0x0052967C File Offset: 0x0052787C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IIntervalSplineSpawnVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IIntervalSplineSpawnVerify.<>O.<0>__Verify = new VerifyTableAction(IPathDrivenActorSplineMoveVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false))
				{
					short offsetId2 = 16;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IIntervalSplineSpawnVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IIntervalSplineSpawnVerify.<>O.<1>__Verify = new VerifyTableAction(IPathDrivenActorInitialSpawnConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 18;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IIntervalSplineSpawnVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IIntervalSplineSpawnVerify.<>O.<2>__Verify = new VerifyTableAction(IIntervalSplineSpawnAllActorAudioVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x020083D0 RID: 33744
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014666 RID: 83558
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014667 RID: 83559
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04014668 RID: 83560
			public static VerifyTableAction <2>__Verify;
		}
	}
}
