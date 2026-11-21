using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CAE RID: 19630
	public static class ICustomScanDirectoryDataVerify
	{
		// Token: 0x0601E1D9 RID: 123353 RVA: 0x00438158 File Offset: 0x00436358
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

		// Token: 0x02008254 RID: 33364
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014423 RID: 82979
			public static VerifyTableAction <0>__Verify;
		}
	}
}
