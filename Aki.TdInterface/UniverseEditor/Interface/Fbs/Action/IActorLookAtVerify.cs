using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060D3 RID: 24787
	public static class IActorLookAtVerify
	{
		// Token: 0x0602A55B RID: 173403 RVA: 0x005D5CD8 File Offset: 0x005D3ED8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IActorLookAtVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IActorLookAtVerify.<>O.<0>__Verify = new VerifyUnionAction(TActorLookAtDataVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007CD4 RID: 31956
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013807 RID: 79879
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
