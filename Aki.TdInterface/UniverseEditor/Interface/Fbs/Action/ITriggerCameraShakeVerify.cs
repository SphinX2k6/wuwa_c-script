using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007474 RID: 29812
	public static class ITriggerCameraShakeVerify
	{
		// Token: 0x06036299 RID: 221849 RVA: 0x0075D188 File Offset: 0x0075B388
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

		// Token: 0x02007EAF RID: 32431
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013BF1 RID: 80881
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
