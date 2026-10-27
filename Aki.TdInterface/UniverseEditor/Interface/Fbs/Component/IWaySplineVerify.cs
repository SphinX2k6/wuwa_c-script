using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B58 RID: 23384
	public static class IWaySplineVerify
	{
		// Token: 0x06028030 RID: 163888 RVA: 0x005804B4 File Offset: 0x0057E6B4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
			{
				short offsetId = 14;
				VerifyTableAction verifyAction;
				if ((verifyAction = IWaySplineVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWaySplineVerify.<>O.<0>__Verify = new VerifyTableAction(IWaySplinePointVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 16, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 18, 4UL, false) && verifier.VerifyField(tablePos, 20, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 22, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C7A RID: 31866
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401379F RID: 79775
			public static VerifyTableAction <0>__Verify;
		}
	}
}
