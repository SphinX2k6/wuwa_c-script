using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BE9 RID: 31721
	public static class IToggleDragActorPlayEnableVerify
	{
		// Token: 0x060392ED RID: 234221 RVA: 0x007B9E28 File Offset: 0x007B8028
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IToggleDragActorPlayEnableVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IToggleDragActorPlayEnableVerify.<>O.<0>__Verify = new VerifyTableAction(IFixedCameraConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200873F RID: 34623
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CC0 RID: 85184
			public static VerifyTableAction <0>__Verify;
		}
	}
}
