using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007773 RID: 30579
	public static class ISetAreaTimeStateVerify
	{
		// Token: 0x06035AC0 RID: 219840 RVA: 0x0073146C File Offset: 0x0072F66C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISetAreaTimeStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetAreaTimeStateVerify.<>O.<0>__Verify = new VerifyUnionAction(TSetAreaTimeTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086C3 RID: 34499
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014ABD RID: 84669
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
