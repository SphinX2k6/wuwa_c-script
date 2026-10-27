using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062B0 RID: 25264
	public static class ICaptureElementalBoxVerify
	{
		// Token: 0x0602BA88 RID: 178824 RVA: 0x00602640 File Offset: 0x00600840
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICaptureElementalBoxVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICaptureElementalBoxVerify.<>O.<0>__Verify = new VerifyUnionAction(TControlElementalBoxTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 8;
					short valueVOffset2 = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = ICaptureElementalBoxVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ICaptureElementalBoxVerify.<>O.<1>__Verify = new VerifyUnionAction(TElementalBoxTargetPosTypeVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007D06 RID: 32006
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013868 RID: 79976
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04013869 RID: 79977
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
