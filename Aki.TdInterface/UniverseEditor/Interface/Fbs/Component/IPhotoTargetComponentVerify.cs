using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200572F RID: 22319
	public static class IPhotoTargetComponentVerify
	{
		// Token: 0x060255C1 RID: 153025 RVA: 0x00527A9C File Offset: 0x00525C9C
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

		// Token: 0x02007BD5 RID: 31701
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013692 RID: 79506
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013693 RID: 79507
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
