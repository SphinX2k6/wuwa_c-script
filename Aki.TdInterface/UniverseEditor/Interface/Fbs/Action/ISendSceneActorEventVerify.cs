using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F7A RID: 28538
	public static class ISendSceneActorEventVerify
	{
		// Token: 0x060326B7 RID: 206519 RVA: 0x006CE510 File Offset: 0x006CC710
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

		// Token: 0x02007E27 RID: 32295
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139E4 RID: 80356
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
