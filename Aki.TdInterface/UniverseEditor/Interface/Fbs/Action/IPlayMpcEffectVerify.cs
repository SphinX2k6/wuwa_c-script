using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D31 RID: 27953
	public static class IPlayMpcEffectVerify
	{
		// Token: 0x06031528 RID: 202024 RVA: 0x006B0960 File Offset: 0x006AEB60
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IPlayMpcEffectVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPlayMpcEffectVerify.<>O.<0>__Verify = new VerifyUnionAction(TPos2Verify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IPlayMpcEffectVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IPlayMpcEffectVerify.<>O.<1>__Verify = new VerifyTableAction(IPostProcessVolumeCenterPositionVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007DFA RID: 32250
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139B3 RID: 80307
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x040139B4 RID: 80308
			public static VerifyTableAction <1>__Verify;
		}
	}
}
