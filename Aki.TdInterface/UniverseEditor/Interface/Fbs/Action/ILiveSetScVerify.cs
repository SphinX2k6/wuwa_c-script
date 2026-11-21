using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200712F RID: 28975
	public static class ILiveSetScVerify
	{
		// Token: 0x06032561 RID: 206177 RVA: 0x006CE4F0 File Offset: 0x006CC6F0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ILiveSetScVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILiveSetScVerify.<>O.<0>__Verify = new VerifyUnionAction(TLiveScOperationVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200861B RID: 34331
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149E5 RID: 84453
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
