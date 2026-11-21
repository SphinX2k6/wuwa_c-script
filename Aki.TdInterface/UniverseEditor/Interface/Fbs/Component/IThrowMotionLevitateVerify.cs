using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200607C RID: 24700
	public static class IThrowMotionLevitateVerify
	{
		// Token: 0x06029BF2 RID: 170994 RVA: 0x005B31C4 File Offset: 0x005B13C4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false))
			{
				short offsetId = 14;
				VerifyTableAction verifyAction;
				if ((verifyAction = IThrowMotionLevitateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IThrowMotionLevitateVerify.<>O.<0>__Verify = new VerifyTableAction(IRenderTrajectoryConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020084CB RID: 33995
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014810 RID: 83984
			public static VerifyTableAction <0>__Verify;
		}
	}
}
