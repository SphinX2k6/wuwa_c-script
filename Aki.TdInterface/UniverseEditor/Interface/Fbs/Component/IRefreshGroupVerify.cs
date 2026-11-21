using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E2F RID: 24111
	public static class IRefreshGroupVerify
	{
		// Token: 0x0602845B RID: 164955 RVA: 0x00581944 File Offset: 0x0057FB44
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 10, 4UL, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRefreshGroupVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRefreshGroupVerify.<>O.<0>__Verify = new VerifyTableAction(ICylinderVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008471 RID: 33905
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014774 RID: 83828
			public static VerifyTableAction <0>__Verify;
		}
	}
}
