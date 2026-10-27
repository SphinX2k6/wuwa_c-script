using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BB8 RID: 15288
	public static class IShowTimelineConfigVerify
	{
		// Token: 0x06014FA8 RID: 85928 RVA: 0x0030ACB0 File Offset: 0x00308EB0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IShowTimelineConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IShowTimelineConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IShowTimelineTrackVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200788F RID: 30863
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040130FC RID: 78076
			public static VerifyTableAction <0>__Verify;
		}
	}
}
