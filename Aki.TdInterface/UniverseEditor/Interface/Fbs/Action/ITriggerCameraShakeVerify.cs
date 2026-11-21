using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C67 RID: 31847
	public static class ITriggerCameraShakeVerify
	{
		// Token: 0x06039682 RID: 235138 RVA: 0x007BFEB4 File Offset: 0x007BE0B4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ITriggerCameraShakeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITriggerCameraShakeVerify.<>O.<0>__Verify = new VerifyUnionAction(TCameraShakeConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyString(tablePos, 8, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008749 RID: 34633
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CCB RID: 85195
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
