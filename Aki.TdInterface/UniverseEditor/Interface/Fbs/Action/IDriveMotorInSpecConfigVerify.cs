using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006614 RID: 26132
	public static class IDriveMotorInSpecConfigVerify
	{
		// Token: 0x0602D626 RID: 185894 RVA: 0x00638108 File Offset: 0x00636308
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IDriveMotorInSpecConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDriveMotorInSpecConfigVerify.<>O.<0>__Verify = new VerifyUnionAction(TMotorParamsChangeConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 10, 1UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D45 RID: 32069
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138BF RID: 80063
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
