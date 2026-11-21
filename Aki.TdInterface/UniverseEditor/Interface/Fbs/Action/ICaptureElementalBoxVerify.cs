using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006921 RID: 26913
	public static class ICaptureElementalBoxVerify
	{
		// Token: 0x0602E1E9 RID: 188905 RVA: 0x0064D448 File Offset: 0x0064B648
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

		// Token: 0x02008579 RID: 34169
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014910 RID: 84240
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04014911 RID: 84241
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
