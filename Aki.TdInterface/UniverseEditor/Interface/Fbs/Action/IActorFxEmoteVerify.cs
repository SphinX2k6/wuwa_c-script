using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060AC RID: 24748
	public static class IActorFxEmoteVerify
	{
		// Token: 0x0602A3ED RID: 173037 RVA: 0x005D2D34 File Offset: 0x005D0F34
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IActorFxEmoteVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IActorFxEmoteVerify.<>O.<0>__Verify = new VerifyUnionAction(TActorFxEmoteVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007CCE RID: 31950
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137FF RID: 79871
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
