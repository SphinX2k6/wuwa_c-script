using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AAC RID: 27308
	public static class ICloseSplineMoveVerify
	{
		// Token: 0x0602EE00 RID: 192000 RVA: 0x0066314C File Offset: 0x0066134C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICloseSplineMoveVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICloseSplineMoveVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200859F RID: 34207
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014943 RID: 84291
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
