using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005176 RID: 20854
	public static class IEntityCustomAudioComponentVerify
	{
		// Token: 0x06021B54 RID: 138068 RVA: 0x004AD64C File Offset: 0x004AB84C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IEntityCustomAudioComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityCustomAudioComponentVerify.<>O.<0>__Verify = new VerifyUnionAction(TAkEventTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 12;
					short valueVOffset2 = 14;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IEntityCustomAudioComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IEntityCustomAudioComponentVerify.<>O.<1>__Verify = new VerifyUnionAction(TAudioControlTypeVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007AF9 RID: 31481
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013519 RID: 79129
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x0401351A RID: 79130
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
