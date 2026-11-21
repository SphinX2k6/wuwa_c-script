using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DAE RID: 23982
	public static class IProjectileMotionVerify
	{
		// Token: 0x06027F83 RID: 163715 RVA: 0x00577994 File Offset: 0x00575B94
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

		// Token: 0x02008458 RID: 33880
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014753 RID: 83795
			public static VerifyTableAction <0>__Verify;
		}
	}
}
