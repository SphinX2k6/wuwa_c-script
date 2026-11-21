using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200607F RID: 24703
	public static class IThrowMotionTrackTargetVerify
	{
		// Token: 0x06029C1C RID: 171036 RVA: 0x005B3720 File Offset: 0x005B1920
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 8, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IThrowMotionTrackTargetVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IThrowMotionTrackTargetVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 14, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020084CC RID: 33996
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014811 RID: 83985
			public static VerifyTableAction <0>__Verify;
		}
	}
}
