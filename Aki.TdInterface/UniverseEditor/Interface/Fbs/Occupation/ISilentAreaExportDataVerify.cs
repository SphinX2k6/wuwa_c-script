using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x0200482F RID: 18479
	public static class ISilentAreaExportDataVerify
	{
		// Token: 0x0601B5C2 RID: 112066 RVA: 0x003E00B8 File Offset: 0x003DE2B8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyString(tablePos, 8, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISilentAreaExportDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISilentAreaExportDataVerify.<>O.<0>__Verify = new VerifyTableAction(ISilentAreaOccupationDataVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020081DB RID: 33243
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401437C RID: 82812
			public static VerifyTableAction <0>__Verify;
		}
	}
}
