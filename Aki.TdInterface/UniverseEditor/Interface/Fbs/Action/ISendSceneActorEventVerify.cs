using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007740 RID: 30528
	public static class ISendSceneActorEventVerify
	{
		// Token: 0x06035907 RID: 219399 RVA: 0x0072DEC8 File Offset: 0x0072C0C8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISendSceneActorEventVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISendSceneActorEventVerify.<>O.<0>__Verify = new VerifyUnionAction(TSceneActorEventVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086BB RID: 34491
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AB4 RID: 84660
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
