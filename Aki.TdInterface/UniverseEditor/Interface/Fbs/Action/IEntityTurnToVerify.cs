using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066F2 RID: 26354
	public static class IEntityTurnToVerify
	{
		// Token: 0x0602DD4D RID: 187725 RVA: 0x006447AC File Offset: 0x006429AC
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

		// Token: 0x02007D58 RID: 32088
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138D6 RID: 80086
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
