using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077C9 RID: 30665
	public static class ISetHeadIconVisibleVerify
	{
		// Token: 0x06035DE0 RID: 220640 RVA: 0x00737A28 File Offset: 0x00735C28
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISetHeadIconVisibleVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetHeadIconVisibleVerify.<>O.<0>__Verify = new VerifyUnionAction(THeadStyleVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086D1 RID: 34513
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AD7 RID: 84695
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
