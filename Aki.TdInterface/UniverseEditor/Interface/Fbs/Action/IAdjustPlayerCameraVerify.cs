using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067CE RID: 26574
	public static class IAdjustPlayerCameraVerify
	{
		// Token: 0x0602D55C RID: 185692 RVA: 0x00635128 File Offset: 0x00633328
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IAdjustPlayerCameraVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAdjustPlayerCameraVerify.<>O.<0>__Verify = new VerifyUnionAction(TAdjustPlayerCameraOptionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200855C RID: 34140
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040148EC RID: 84204
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
