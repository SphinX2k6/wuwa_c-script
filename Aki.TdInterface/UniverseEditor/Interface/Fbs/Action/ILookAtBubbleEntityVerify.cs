using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A58 RID: 27224
	public static class ILookAtBubbleEntityVerify
	{
		// Token: 0x0602FAB9 RID: 195257 RVA: 0x0067CE54 File Offset: 0x0067B054
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILookAtBubbleEntityVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILookAtBubbleEntityVerify.<>O.<0>__Verify = new VerifyTableAction(ILookAtBubbleEntityConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D9E RID: 32158
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013936 RID: 80182
			public static VerifyTableAction <0>__Verify;
		}
	}
}
