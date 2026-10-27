using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074E0 RID: 29920
	public static class IUnlockSystemItemVerify
	{
		// Token: 0x0603664F RID: 222799 RVA: 0x00763E74 File Offset: 0x00762074
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

		// Token: 0x02007EBA RID: 32442
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013C01 RID: 80897
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
