using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D16 RID: 23830
	public static class IPatrolRangeVerify
	{
		// Token: 0x06027939 RID: 162105 RVA: 0x00569DDC File Offset: 0x00567FDC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPatrolRangeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPatrolRangeVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200843E RID: 33854
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014726 RID: 83750
			public static VerifyTableAction <0>__Verify;
		}
	}
}
