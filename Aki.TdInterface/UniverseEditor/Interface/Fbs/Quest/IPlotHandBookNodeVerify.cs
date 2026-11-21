using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043ED RID: 17389
	public static class IPlotHandBookNodeVerify
	{
		// Token: 0x06018B56 RID: 101206 RVA: 0x00385AAC File Offset: 0x00383CAC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPlotHandBookNodeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPlotHandBookNodeVerify.<>O.<0>__Verify = new VerifyTableAction(IFlowStateIndexVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008164 RID: 33124
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401426B RID: 82539
			public static VerifyTableAction <0>__Verify;
		}
	}
}
