using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x0200438E RID: 17294
	public static class IAreaExportDataVerify
	{
		// Token: 0x06019BB0 RID: 105392 RVA: 0x003AF498 File Offset: 0x003AD698
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyString(tablePos, 8, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAreaExportDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAreaExportDataVerify.<>O.<0>__Verify = new VerifyTableAction(IAreaOccupationDataVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200798A RID: 31114
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013308 RID: 78600
			public static VerifyTableAction <0>__Verify;
		}
	}
}
