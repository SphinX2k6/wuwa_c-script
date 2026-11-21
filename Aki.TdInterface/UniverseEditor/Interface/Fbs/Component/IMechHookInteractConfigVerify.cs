using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AD0 RID: 23248
	public static class IMechHookInteractConfigVerify
	{
		// Token: 0x0602625D RID: 156253 RVA: 0x0053A0A4 File Offset: 0x005382A4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IMechHookInteractConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMechHookInteractConfigVerify.<>O.<0>__Verify = new VerifyUnionAction(TMechHookInteractTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IMechHookInteractConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IMechHookInteractConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IMechHookAccelerationVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false))
					{
						short offsetId2 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IMechHookInteractConfigVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IMechHookInteractConfigVerify.<>O.<2>__Verify = new VerifyTableAction(IInteractSectorRangeVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId2, verifyAction3, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x020083ED RID: 33773
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401469D RID: 83613
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x0401469E RID: 83614
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401469F RID: 83615
			public static VerifyTableAction <2>__Verify;
		}
	}
}
