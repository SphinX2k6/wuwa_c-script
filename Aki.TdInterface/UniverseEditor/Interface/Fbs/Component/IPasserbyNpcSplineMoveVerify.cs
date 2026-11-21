using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CD1 RID: 23761
	public static class IPasserbyNpcSplineMoveVerify
	{
		// Token: 0x06027716 RID: 161558 RVA: 0x00566004 File Offset: 0x00564204
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPasserbyNpcSplineMoveVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPasserbyNpcSplineMoveVerify.<>O.<0>__Verify = new VerifyTableAction(IPasserbyNpcSplineVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008437 RID: 33847
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401471E RID: 83742
			public static VerifyTableAction <0>__Verify;
		}
	}
}
