using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005828 RID: 22568
	public static class IRefreshGroupVerify
	{
		// Token: 0x06025F3B RID: 155451 RVA: 0x0053B7B8 File Offset: 0x005399B8
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

		// Token: 0x02007C03 RID: 31747
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136D4 RID: 79572
			public static VerifyTableAction <0>__Verify;
		}
	}
}
