using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060F9 RID: 24825
	public static class ITriggerMatchConfigVerify
	{
		// Token: 0x0602A13F RID: 172351 RVA: 0x005BE7A8 File Offset: 0x005BC9A8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ITriggerMatchConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITriggerMatchConfigVerify.<>O.<0>__Verify = new VerifyUnionAction(TEntityMatchVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020084DE RID: 34014
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014833 RID: 84019
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
