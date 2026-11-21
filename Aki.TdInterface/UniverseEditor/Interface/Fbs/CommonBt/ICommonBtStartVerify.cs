using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02006511 RID: 25873
	public static class ICommonBtStartVerify
	{
		// Token: 0x0602C191 RID: 180625 RVA: 0x00601BC0 File Offset: 0x005FFDC0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyVectorOfData(tablePos, 10, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
			{
				short typeIdVOffset = 16;
				short valueVOffset = 18;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICommonBtStartVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICommonBtStartVerify.<>O.<0>__Verify = new VerifyUnionAction(TCommonBtNodeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008530 RID: 34096
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014895 RID: 84117
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
