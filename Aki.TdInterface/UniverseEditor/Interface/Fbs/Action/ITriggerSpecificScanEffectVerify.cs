using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C7F RID: 31871
	public static class ITriggerSpecificScanEffectVerify
	{
		// Token: 0x0603977E RID: 235390 RVA: 0x007C1F68 File Offset: 0x007C0168
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ITriggerSpecificScanEffectVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITriggerSpecificScanEffectVerify.<>O.<0>__Verify = new VerifyUnionAction(TSpecificScanEffectVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200874D RID: 34637
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CD3 RID: 85203
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
