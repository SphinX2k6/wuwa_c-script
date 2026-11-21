using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075DE RID: 30174
	public static class IRemovePreloadResourceActionVerify
	{
		// Token: 0x06034EF9 RID: 216825 RVA: 0x0071CEEC File Offset: 0x0071B0EC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IRemovePreloadResourceActionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRemovePreloadResourceActionVerify.<>O.<0>__Verify = new VerifyUnionAction(TRemovePreloadResourceConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200869B RID: 34459
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A8E RID: 84622
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
