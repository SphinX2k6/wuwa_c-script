using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D72 RID: 28018
	public static class IEntityTurnToVerify
	{
		// Token: 0x0603058A RID: 198026 RVA: 0x00691D20 File Offset: 0x0068FF20
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IEntityTurnToVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityTurnToVerify.<>O.<0>__Verify = new VerifyUnionAction(TActorTurnToDataVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020085CF RID: 34255
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014982 RID: 84354
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
