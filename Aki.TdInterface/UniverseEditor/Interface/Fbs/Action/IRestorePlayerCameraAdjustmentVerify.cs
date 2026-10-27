using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EBD RID: 28349
	public static class IRestorePlayerCameraAdjustmentVerify
	{
		// Token: 0x060321B5 RID: 205237 RVA: 0x006C64A0 File Offset: 0x006C46A0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRestorePlayerCameraAdjustmentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRestorePlayerCameraAdjustmentVerify.<>O.<0>__Verify = new VerifyTableAction(IResetFocusConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 6, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E19 RID: 32281
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139D5 RID: 80341
			public static VerifyTableAction <0>__Verify;
		}
	}
}
