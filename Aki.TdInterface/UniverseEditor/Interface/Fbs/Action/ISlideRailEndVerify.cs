using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007913 RID: 30995
	public static class ISlideRailEndVerify
	{
		// Token: 0x0603693B RID: 223547 RVA: 0x0074E0AC File Offset: 0x0074C2AC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISlideRailEndVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISlideRailEndVerify.<>O.<0>__Verify = new VerifyUnionAction(TSlideRailEndVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086FB RID: 34555
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014B17 RID: 84759
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
