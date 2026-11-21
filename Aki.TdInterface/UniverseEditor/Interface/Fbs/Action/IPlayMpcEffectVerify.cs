using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074AC RID: 29868
	public static class IPlayMpcEffectVerify
	{
		// Token: 0x06034524 RID: 214308 RVA: 0x0070C048 File Offset: 0x0070A248
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

		// Token: 0x02008686 RID: 34438
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A77 RID: 84599
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04014A78 RID: 84600
			public static VerifyTableAction <1>__Verify;
		}
	}
}
