using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053E7 RID: 21479
	public static class IAttachTargetComponentVerify
	{
		// Token: 0x0602190C RID: 137484 RVA: 0x004A0DFC File Offset: 0x0049EFFC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IAttachTargetComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAttachTargetComponentVerify.<>O.<0>__Verify = new VerifyUnionAction(TAttachTargetVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 14;
					short valueVOffset2 = 16;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IAttachTargetComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IAttachTargetComponentVerify.<>O.<1>__Verify = new VerifyUnionAction(TAttachTimingVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020082D6 RID: 33494
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144C6 RID: 83142
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x040144C7 RID: 83143
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
