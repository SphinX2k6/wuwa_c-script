using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ADE RID: 27358
	public static class ICommonBtPlaceholderVerify
	{
		// Token: 0x0602F01B RID: 192539 RVA: 0x0066928C File Offset: 0x0066748C
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

		// Token: 0x020085A4 RID: 34212
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014949 RID: 84297
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
