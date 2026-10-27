using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A6F RID: 23151
	public static class IThrowMotionLevitateVerify
	{
		// Token: 0x0602767A RID: 161402 RVA: 0x0056C1B8 File Offset: 0x0056A3B8
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

		// Token: 0x02007C5C RID: 31836
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401376C RID: 79724
			public static VerifyTableAction <0>__Verify;
		}
	}
}
