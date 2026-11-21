using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200742C RID: 29740
	public static class IPhotographCameraParamsVerify
	{
		// Token: 0x0603408F RID: 213135 RVA: 0x007032F0 File Offset: 0x007014F0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPhotographCameraParamsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPhotographCameraParamsVerify.<>O.<0>__Verify = new VerifyTableAction(IPhotographCameraTransformAbsoluteVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008673 RID: 34419
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A5D RID: 84573
			public static VerifyTableAction <0>__Verify;
		}
	}
}
