using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005531 RID: 21809
	public static class ICommonSplineVerify
	{
		// Token: 0x060227CE RID: 141262 RVA: 0x004C0228 File Offset: 0x004BE428
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICommonSplineVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICommonSplineVerify.<>O.<0>__Verify = new VerifyTableAction(ICommonSplinePointVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008310 RID: 33552
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014522 RID: 83234
			public static VerifyTableAction <0>__Verify;
		}
	}
}
