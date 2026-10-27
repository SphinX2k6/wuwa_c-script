using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x0200474D RID: 18253
	public static class IPlotPosPlayFlowVerify
	{
		// Token: 0x0601C188 RID: 115080 RVA: 0x003FB0F0 File Offset: 0x003F92F0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPlotPosPlayFlowVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPlotPosPlayFlowVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079E8 RID: 31208
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013393 RID: 78739
			public static VerifyTableAction <0>__Verify;
		}
	}
}
