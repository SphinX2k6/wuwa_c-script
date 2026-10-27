using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DED RID: 24045
	public static class IGiantTriggerStableValueVerify
	{
		// Token: 0x06029297 RID: 168599 RVA: 0x005A5F9C File Offset: 0x005A419C
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

		// Token: 0x02007CAC RID: 31916
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137D9 RID: 79833
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
