using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F70 RID: 28528
	public static class IHandInHandInitiatorVerify
	{
		// Token: 0x06031617 RID: 202263 RVA: 0x006B26A4 File Offset: 0x006B08A4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IHandInHandInitiatorVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IHandInHandInitiatorVerify.<>O.<0>__Verify = new VerifyUnionAction(THandInHandInitiatorVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020085FF RID: 34303
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149BC RID: 84412
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
