using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D36 RID: 23862
	public static class IPhotoTargetComponentVerify
	{
		// Token: 0x06027AE1 RID: 162529 RVA: 0x0056DC28 File Offset: 0x0056BE28
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPhotoTargetComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPhotoTargetComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset = 8;
					short valueVOffset = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IPhotoTargetComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IPhotoTargetComponentVerify.<>O.<1>__Verify = new VerifyUnionAction(TPhotoTargetCaptureUiVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false) && verifier.VerifyVectorOfData(tablePos, 12, 4UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008443 RID: 33859
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014732 RID: 83762
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014733 RID: 83763
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
