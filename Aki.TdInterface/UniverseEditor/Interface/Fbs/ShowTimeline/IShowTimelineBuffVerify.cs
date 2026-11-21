using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FB7 RID: 16311
	public static class IShowTimelineBuffVerify
	{
		// Token: 0x06016404 RID: 91140 RVA: 0x003302C4 File Offset: 0x0032E4C4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 8UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IShowTimelineBuffVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IShowTimelineBuffVerify.<>O.<0>__Verify = new VerifyTableAction(IShowTimelineRoleBuffVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020080D1 RID: 32977
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014153 RID: 82259
			public static VerifyTableAction <0>__Verify;
		}
	}
}
