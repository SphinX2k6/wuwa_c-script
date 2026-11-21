using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200642A RID: 25642
	public static class IGiantTriggerStableValueVerify
	{
		// Token: 0x0602B921 RID: 178465 RVA: 0x005EECCC File Offset: 0x005ECECC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IGiantTriggerStableValueVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGiantTriggerStableValueVerify.<>O.<0>__Verify = new VerifyUnionAction(TGiantStableValueVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200851D RID: 34077
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401487F RID: 84095
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
