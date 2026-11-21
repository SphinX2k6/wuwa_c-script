using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F29 RID: 24361
	public static class ISkyboxComponentVerify
	{
		// Token: 0x06028E9D RID: 167581 RVA: 0x00597008 File Offset: 0x00595208
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
			{
				short typeIdVOffset = 16;
				short valueVOffset = 18;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISkyboxComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISkyboxComponentVerify.<>O.<0>__Verify = new VerifyUnionAction(TTriggerModeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200849C RID: 33948
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147B5 RID: 83893
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
