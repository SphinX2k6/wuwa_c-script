using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A84 RID: 27268
	public static class IMechEscortPointVerify
	{
		// Token: 0x0602FC8F RID: 195727 RVA: 0x006809C4 File Offset: 0x0067EBC4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
			{
				short typeIdVOffset = 12;
				short valueVOffset = 14;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IMechEscortPointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMechEscortPointVerify.<>O.<0>__Verify = new VerifyUnionAction(TEnterMovieCameraTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007DA5 RID: 32165
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401393E RID: 80190
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
