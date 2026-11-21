using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D72 RID: 19826
	public static class ICircuitConnectAssetsVerify
	{
		// Token: 0x0601EBB0 RID: 125872 RVA: 0x0044C604 File Offset: 0x0044A804
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICircuitConnectAssetsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICircuitConnectAssetsVerify.<>O.<0>__Verify = new VerifyTableAction(ICircuitConnectAssetConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008265 RID: 33381
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014443 RID: 83011
			public static VerifyTableAction <0>__Verify;
		}
	}
}
