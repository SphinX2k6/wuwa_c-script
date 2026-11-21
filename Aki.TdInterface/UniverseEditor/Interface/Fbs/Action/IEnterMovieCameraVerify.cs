using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D27 RID: 27943
	public static class IEnterMovieCameraVerify
	{
		// Token: 0x06030328 RID: 197416 RVA: 0x0068D918 File Offset: 0x0068BB18
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

		// Token: 0x020085C7 RID: 34247
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014977 RID: 84343
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
