using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066AD RID: 26285
	public static class IEnterMovieCameraVerify
	{
		// Token: 0x0602DB0B RID: 187147 RVA: 0x00640664 File Offset: 0x0063E864
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IEnterMovieCameraVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEnterMovieCameraVerify.<>O.<0>__Verify = new VerifyUnionAction(TEnterMovieCameraTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D50 RID: 32080
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138CB RID: 80075
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
