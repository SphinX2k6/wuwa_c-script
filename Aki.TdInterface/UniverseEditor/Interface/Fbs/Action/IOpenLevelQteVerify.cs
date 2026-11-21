using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007372 RID: 29554
	public static class IOpenLevelQteVerify
	{
		// Token: 0x06033966 RID: 211302 RVA: 0x006F4094 File Offset: 0x006F2294
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IOpenLevelQteVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IOpenLevelQteVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200865C RID: 34396
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A39 RID: 84537
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
