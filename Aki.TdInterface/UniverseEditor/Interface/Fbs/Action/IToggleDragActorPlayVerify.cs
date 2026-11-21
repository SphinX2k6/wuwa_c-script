using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BE3 RID: 31715
	public static class IToggleDragActorPlayVerify
	{
		// Token: 0x060392A7 RID: 234151 RVA: 0x007B9678 File Offset: 0x007B7878
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

		// Token: 0x0200873E RID: 34622
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CBF RID: 85183
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
