using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005484 RID: 21636
	public static class IIntervalSplineSpawnVerify
	{
		// Token: 0x060239B0 RID: 145840 RVA: 0x004EC608 File Offset: 0x004EA808
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

		// Token: 0x02007B71 RID: 31601
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040135E0 RID: 79328
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040135E1 RID: 79329
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040135E2 RID: 79330
			public static VerifyTableAction <2>__Verify;
		}
	}
}
