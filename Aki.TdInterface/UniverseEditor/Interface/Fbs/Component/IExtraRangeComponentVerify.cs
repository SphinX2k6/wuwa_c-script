using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005215 RID: 21013
	public static class IExtraRangeComponentVerify
	{
		// Token: 0x06022269 RID: 139881 RVA: 0x004BD040 File Offset: 0x004BB240
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IExtraRangeComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IExtraRangeComponentVerify.<>O.<0>__Verify = new VerifyTableAction(ISunSpiritBlockExtraRangeVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B18 RID: 31512
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401354B RID: 79179
			public static VerifyTableAction <0>__Verify;
		}
	}
}
