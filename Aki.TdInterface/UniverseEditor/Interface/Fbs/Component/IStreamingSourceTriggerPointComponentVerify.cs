using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059DF RID: 23007
	public static class IStreamingSourceTriggerPointComponentVerify
	{
		// Token: 0x06027087 RID: 159879 RVA: 0x0055EE3C File Offset: 0x0055D03C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IStreamingSourceTriggerPointComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IStreamingSourceTriggerPointComponentVerify.<>O.<0>__Verify = new VerifyUnionAction(TStreamingSourceConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C44 RID: 31812
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401373C RID: 79676
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
