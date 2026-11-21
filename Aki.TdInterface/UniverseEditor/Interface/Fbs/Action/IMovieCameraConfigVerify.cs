using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072B6 RID: 29366
	public static class IMovieCameraConfigVerify
	{
		// Token: 0x0603331B RID: 209691 RVA: 0x006E875C File Offset: 0x006E695C
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

		// Token: 0x02008649 RID: 34377
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A23 RID: 84515
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
