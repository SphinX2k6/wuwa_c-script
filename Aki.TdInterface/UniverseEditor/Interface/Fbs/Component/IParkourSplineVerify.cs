using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056B5 RID: 22197
	public static class IParkourSplineVerify
	{
		// Token: 0x06025101 RID: 151809 RVA: 0x0051DE98 File Offset: 0x0051C098
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyString(tablePos, 14, false) && verifier.VerifyString(tablePos, 16, false))
			{
				short offsetId = 18;
				VerifyTableAction verifyAction;
				if ((verifyAction = IParkourSplineVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IParkourSplineVerify.<>O.<0>__Verify = new VerifyTableAction(IParkourSplinePointVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007BC4 RID: 31684
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013675 RID: 79477
			public static VerifyTableAction <0>__Verify;
		}
	}
}
