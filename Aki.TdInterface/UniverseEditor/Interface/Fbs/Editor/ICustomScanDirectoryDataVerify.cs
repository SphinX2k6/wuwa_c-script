using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004846 RID: 18502
	public static class ICustomScanDirectoryDataVerify
	{
		// Token: 0x0601C9DC RID: 117212 RVA: 0x0040B808 File Offset: 0x00409A08
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyVectorOfStrings(tablePos, 8, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICustomScanDirectoryDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICustomScanDirectoryDataVerify.<>O.<0>__Verify = new VerifyTableAction(IScanDirectoryVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A0B RID: 31243
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133BC RID: 78780
			public static VerifyTableAction <0>__Verify;
		}
	}
}
