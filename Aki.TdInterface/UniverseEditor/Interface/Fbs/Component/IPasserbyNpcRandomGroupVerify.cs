using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CAA RID: 23722
	public static class IPasserbyNpcRandomGroupVerify
	{
		// Token: 0x060275BC RID: 161212 RVA: 0x005633D4 File Offset: 0x005615D4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPasserbyNpcRandomGroupVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPasserbyNpcRandomGroupVerify.<>O.<0>__Verify = new VerifyTableAction(IPasserbyNpcStandPosVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008432 RID: 33842
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014712 RID: 83730
			public static VerifyTableAction <0>__Verify;
		}
	}
}
