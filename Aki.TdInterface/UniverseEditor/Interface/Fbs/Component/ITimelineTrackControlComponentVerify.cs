using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A7E RID: 23166
	public static class ITimelineTrackControlComponentVerify
	{
		// Token: 0x0602775A RID: 161626 RVA: 0x0056E080 File Offset: 0x0056C280
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITimelineTrackControlComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITimelineTrackControlComponentVerify.<>O.<0>__Verify = new VerifyTableAction(ITimelineControlGroupVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C5F RID: 31839
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013770 RID: 79728
			public static VerifyTableAction <0>__Verify;
		}
	}
}
