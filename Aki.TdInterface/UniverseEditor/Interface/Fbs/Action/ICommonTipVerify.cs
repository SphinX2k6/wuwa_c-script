using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AEA RID: 27370
	public static class ICommonTipVerify
	{
		// Token: 0x0602F0D1 RID: 192721 RVA: 0x0066B504 File Offset: 0x00669704
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICommonTipVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICommonTipVerify.<>O.<0>__Verify = new VerifyUnionAction(TCommonTipOptionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020085A6 RID: 34214
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401494B RID: 84299
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
