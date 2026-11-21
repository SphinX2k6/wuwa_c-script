using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004DC3 RID: 19907
	public static class ITurntableConnectorNormalDiskSocketsVerify
	{
		// Token: 0x0601EE38 RID: 126520 RVA: 0x00450C88 File Offset: 0x0044EE88
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITurntableConnectorNormalDiskSocketsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITurntableConnectorNormalDiskSocketsVerify.<>O.<0>__Verify = new VerifyTableAction(ITurntableConnectorDiskSocketVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200826B RID: 33387
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401444C RID: 83020
			public static VerifyTableAction <0>__Verify;
		}
	}
}
