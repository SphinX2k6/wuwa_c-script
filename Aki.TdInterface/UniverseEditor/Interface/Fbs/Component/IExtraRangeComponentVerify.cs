using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200577D RID: 22397
	public static class IExtraRangeComponentVerify
	{
		// Token: 0x060241FF RID: 147967 RVA: 0x004F7B04 File Offset: 0x004F5D04
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

		// Token: 0x02008373 RID: 33651
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145CB RID: 83403
			public static VerifyTableAction <0>__Verify;
		}
	}
}
