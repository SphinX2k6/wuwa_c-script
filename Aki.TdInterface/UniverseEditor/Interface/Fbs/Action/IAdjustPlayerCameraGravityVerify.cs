using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200616C RID: 24940
	public static class IAdjustPlayerCameraGravityVerify
	{
		// Token: 0x0602AE85 RID: 175749 RVA: 0x005EB448 File Offset: 0x005E9648
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IAdjustPlayerCameraGravityVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAdjustPlayerCameraGravityVerify.<>O.<0>__Verify = new VerifyUnionAction(TGravityDirectionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 10, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007CEC RID: 31980
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013847 RID: 79943
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
