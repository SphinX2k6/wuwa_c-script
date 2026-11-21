using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007641 RID: 30273
	public static class IRestorePlayerCameraAdjustmentVerify
	{
		// Token: 0x060351F5 RID: 217589 RVA: 0x007221D4 File Offset: 0x007203D4
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

		// Token: 0x020086A5 RID: 34469
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A99 RID: 84633
			public static VerifyTableAction <0>__Verify;
		}
	}
}
