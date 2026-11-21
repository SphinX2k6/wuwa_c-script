using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007390 RID: 29584
	public static class IOpenQuickHackSystemVerify
	{
		// Token: 0x06033A92 RID: 211602 RVA: 0x006F6A30 File Offset: 0x006F4C30
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IOpenQuickHackSystemVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IOpenQuickHackSystemVerify.<>O.<0>__Verify = new VerifyTableAction(IOpenQuickHackCameraConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008662 RID: 34402
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A41 RID: 84545
			public static VerifyTableAction <0>__Verify;
		}
	}
}
