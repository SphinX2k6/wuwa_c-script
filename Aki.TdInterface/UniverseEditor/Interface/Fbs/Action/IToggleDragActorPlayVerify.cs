using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073F9 RID: 29689
	public static class IToggleDragActorPlayVerify
	{
		// Token: 0x06035EF4 RID: 220916 RVA: 0x00756F04 File Offset: 0x00755104
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IToggleDragActorPlayVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IToggleDragActorPlayVerify.<>O.<0>__Verify = new VerifyUnionAction(TToggleDragActorPlayVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007EA5 RID: 32421
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013BE6 RID: 80870
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
