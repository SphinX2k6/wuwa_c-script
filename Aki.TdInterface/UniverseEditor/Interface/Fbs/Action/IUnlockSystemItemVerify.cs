using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CD6 RID: 31958
	public static class IUnlockSystemItemVerify
	{
		// Token: 0x06039A64 RID: 236132 RVA: 0x007C70C4 File Offset: 0x007C52C4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IUnlockSystemItemVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IUnlockSystemItemVerify.<>O.<0>__Verify = new VerifyUnionAction(TUnlockSystemOptionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008754 RID: 34644
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CDB RID: 85211
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
