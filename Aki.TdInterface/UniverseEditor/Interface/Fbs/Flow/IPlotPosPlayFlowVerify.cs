using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004BB5 RID: 19381
	public static class IPlotPosPlayFlowVerify
	{
		// Token: 0x0601D95D RID: 121181 RVA: 0x0042738C File Offset: 0x0042558C
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

		// Token: 0x02008231 RID: 33329
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143FA RID: 82938
			public static VerifyTableAction <0>__Verify;
		}
	}
}
