using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FC0 RID: 16320
	public static class IShowTimelineConfigVerify
	{
		// Token: 0x06016480 RID: 91264 RVA: 0x0033150C File Offset: 0x0032F70C
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

		// Token: 0x020080D3 RID: 32979
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014158 RID: 82264
			public static VerifyTableAction <0>__Verify;
		}
	}
}
