using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046EA RID: 18154
	public static class IWarningPreformVerify
	{
		// Token: 0x0601AB50 RID: 109392 RVA: 0x003CBD38 File Offset: 0x003C9F38
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IWarningPreformVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWarningPreformVerify.<>O.<0>__Verify = new VerifyUnionAction(TWarningPreformConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020081CB RID: 33227
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014365 RID: 82789
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
