using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C85 RID: 27781
	public static class IDriveMotorInSpecConfigVerify
	{
		// Token: 0x0602FDF7 RID: 196087 RVA: 0x00684C70 File Offset: 0x00682E70
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

		// Token: 0x020085BC RID: 34236
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401496B RID: 84331
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
