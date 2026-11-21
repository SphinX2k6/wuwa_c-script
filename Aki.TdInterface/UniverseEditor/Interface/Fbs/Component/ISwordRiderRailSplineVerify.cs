using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006022 RID: 24610
	public static class ISwordRiderRailSplineVerify
	{
		// Token: 0x0602980A RID: 169994 RVA: 0x005AA040 File Offset: 0x005A8240
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 8, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISwordRiderRailSplineVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISwordRiderRailSplineVerify.<>O.<0>__Verify = new VerifyTableAction(ISwordRiderRailSplinePointVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020084BC RID: 33980
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147EB RID: 83947
			public static VerifyTableAction <0>__Verify;
		}
	}
}
