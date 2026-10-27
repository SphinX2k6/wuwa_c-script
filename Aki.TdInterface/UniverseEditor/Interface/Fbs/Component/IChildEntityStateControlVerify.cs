using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F9C RID: 20380
	public static class IChildEntityStateControlVerify
	{
		// Token: 0x06020690 RID: 132752 RVA: 0x00482548 File Offset: 0x00480748
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IChildEntityStateControlVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IChildEntityStateControlVerify.<>O.<0>__Verify = new VerifyTableAction(IChildStateChangedConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007AAD RID: 31405
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013499 RID: 79001
			public static VerifyTableAction <0>__Verify;
		}
	}
}
