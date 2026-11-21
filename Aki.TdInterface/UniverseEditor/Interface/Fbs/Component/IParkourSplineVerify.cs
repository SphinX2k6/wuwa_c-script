using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C59 RID: 23641
	public static class IParkourSplineVerify
	{
		// Token: 0x06027356 RID: 160598 RVA: 0x0055EDE0 File Offset: 0x0055CFE0
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

		// Token: 0x02008427 RID: 33831
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014705 RID: 83717
			public static VerifyTableAction <0>__Verify;
		}
	}
}
