using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AEC RID: 23276
	public static class ITriggerMatchConfigVerify
	{
		// Token: 0x06027BB3 RID: 162739 RVA: 0x005772E4 File Offset: 0x005754E4
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

		// Token: 0x02007C6E RID: 31854
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401378E RID: 79758
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
