using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055AC RID: 21932
	public static class ICurveControlComponentVerify
	{
		// Token: 0x06022E42 RID: 142914 RVA: 0x004CE0D4 File Offset: 0x004CC2D4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICurveControlComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICurveControlComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IChargeSlashControlVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008328 RID: 33576
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401454B RID: 83275
			public static VerifyTableAction <0>__Verify;
		}
	}
}
