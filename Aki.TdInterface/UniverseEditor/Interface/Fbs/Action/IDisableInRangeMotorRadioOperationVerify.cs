using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C4F RID: 27727
	public static class IDisableInRangeMotorRadioOperationVerify
	{
		// Token: 0x0602FBB8 RID: 195512 RVA: 0x0068019C File Offset: 0x0067E39C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IDisableInRangeMotorRadioOperationVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDisableInRangeMotorRadioOperationVerify.<>O.<0>__Verify = new VerifyUnionAction(TMotorRadioDisableRangeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020085B8 RID: 34232
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014961 RID: 84321
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
