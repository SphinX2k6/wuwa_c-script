using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067D1 RID: 26577
	public static class IAdjustPlayerCameraGravityVerify
	{
		// Token: 0x0602D57E RID: 185726 RVA: 0x00635624 File Offset: 0x00633824
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

		// Token: 0x0200855D RID: 34141
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040148ED RID: 84205
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
