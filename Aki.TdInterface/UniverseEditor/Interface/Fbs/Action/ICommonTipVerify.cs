using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200647F RID: 25727
	public static class ICommonTipVerify
	{
		// Token: 0x0602C957 RID: 182615 RVA: 0x0061F930 File Offset: 0x0061DB30
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

		// Token: 0x02007D31 RID: 32049
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138A0 RID: 80032
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
