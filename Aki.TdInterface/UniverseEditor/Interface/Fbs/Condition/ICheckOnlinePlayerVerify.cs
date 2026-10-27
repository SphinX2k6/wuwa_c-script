using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AD4 RID: 19156
	public static class ICheckOnlinePlayerVerify
	{
		// Token: 0x0601E15D RID: 123229 RVA: 0x004386F4 File Offset: 0x004368F4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICheckOnlinePlayerVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckOnlinePlayerVerify.<>O.<0>__Verify = new VerifyUnionAction(TOnlinePlayerConditionTargetVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A3F RID: 31295
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013403 RID: 78851
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
