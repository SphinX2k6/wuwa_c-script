using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C92 RID: 23698
	public static class IPasserbyNpcLiftStopExitTimingVerify
	{
		// Token: 0x060274F4 RID: 161012 RVA: 0x00561E38 File Offset: 0x00560038
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPasserbyNpcLiftStopExitTimingVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPasserbyNpcLiftStopExitTimingVerify.<>O.<0>__Verify = new VerifyTableAction(IPasserbyNpcIntervalExitVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200842F RID: 33839
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401470F RID: 83727
			public static VerifyTableAction <0>__Verify;
		}
	}
}
