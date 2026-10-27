using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006169 RID: 24937
	public static class IAdjustPlayerCameraVerify
	{
		// Token: 0x0602AE63 RID: 175715 RVA: 0x005EAF4C File Offset: 0x005E914C
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

		// Token: 0x02007CEB RID: 31979
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013846 RID: 79942
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
