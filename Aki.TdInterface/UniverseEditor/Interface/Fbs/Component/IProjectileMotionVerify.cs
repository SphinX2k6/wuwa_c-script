using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057A7 RID: 22439
	public static class IProjectileMotionVerify
	{
		// Token: 0x06025A63 RID: 154211 RVA: 0x00531808 File Offset: 0x0052FA08
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 10, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = IProjectileMotionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IProjectileMotionVerify.<>O.<0>__Verify = new VerifyTableAction(ISpeedCurveMotionVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007BEA RID: 31722
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136B3 RID: 79539
			public static VerifyTableAction <0>__Verify;
		}
	}
}
