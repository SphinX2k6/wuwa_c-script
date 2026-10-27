using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005ECE RID: 24270
	public static class ICommonBtStartVerify
	{
		// Token: 0x06029ADD RID: 170717 RVA: 0x005B86DC File Offset: 0x005B68DC
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

		// Token: 0x02007CBF RID: 31935
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137EF RID: 79855
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
