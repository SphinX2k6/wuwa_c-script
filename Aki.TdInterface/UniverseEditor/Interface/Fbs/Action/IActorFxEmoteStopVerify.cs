using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060B5 RID: 24757
	public static class IActorFxEmoteStopVerify
	{
		// Token: 0x0602A459 RID: 173145 RVA: 0x005D3C04 File Offset: 0x005D1E04
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IActorFxEmoteStopVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IActorFxEmoteStopVerify.<>O.<0>__Verify = new VerifyUnionAction(TActorFxEmoteStopSubTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007CD1 RID: 31953
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013802 RID: 79874
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
