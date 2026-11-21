using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F4F RID: 20303
	public static class ICheckIsEntityTimeScaleEnabledVerify
	{
		// Token: 0x0601F96E RID: 129390 RVA: 0x00464FD8 File Offset: 0x004631D8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICheckIsEntityTimeScaleEnabledVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckIsEntityTimeScaleEnabledVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008287 RID: 33415
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014469 RID: 83049
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
