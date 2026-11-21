using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020047F0 RID: 18416
	public static class IAreaExportDataVerify
	{
		// Token: 0x0601B33E RID: 111422 RVA: 0x003DAEC0 File Offset: 0x003D90C0
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

		// Token: 0x020081D3 RID: 33235
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401436F RID: 82799
			public static VerifyTableAction <0>__Verify;
		}
	}
}
