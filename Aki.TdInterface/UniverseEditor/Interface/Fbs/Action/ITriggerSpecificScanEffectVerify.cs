using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200748C RID: 29836
	public static class ITriggerSpecificScanEffectVerify
	{
		// Token: 0x06036391 RID: 222097 RVA: 0x0075F1AC File Offset: 0x0075D3AC
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

		// Token: 0x02007EB3 RID: 32435
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013BF9 RID: 80889
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
