using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FAC RID: 16300
	public static class IPlotHandBookNodeVerify
	{
		// Token: 0x060174C7 RID: 95431 RVA: 0x0035BE94 File Offset: 0x0035A094
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

		// Token: 0x0200791D RID: 31005
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013209 RID: 78345
			public static VerifyTableAction <0>__Verify;
		}
	}
}
