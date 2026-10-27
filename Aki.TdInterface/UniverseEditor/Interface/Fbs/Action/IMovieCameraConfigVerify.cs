using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B70 RID: 27504
	public static class IMovieCameraConfigVerify
	{
		// Token: 0x060304C3 RID: 197827 RVA: 0x0069013C File Offset: 0x0068E33C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IMovieCameraConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMovieCameraConfigVerify.<>O.<0>__Verify = new VerifyUnionAction(TEnterMovieCameraTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007DC1 RID: 32193
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013964 RID: 80228
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
