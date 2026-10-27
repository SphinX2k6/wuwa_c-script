using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006476 RID: 25718
	public static class ICommonBtPlaceholderVerify
	{
		// Token: 0x0602C8CA RID: 182474 RVA: 0x0061DC80 File Offset: 0x0061BE80
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICommonBtPlaceholderVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICommonBtPlaceholderVerify.<>O.<0>__Verify = new VerifyUnionAction(TCommonBtPlaceholderValueVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 12, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D2F RID: 32047
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401389E RID: 80030
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
