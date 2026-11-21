using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CF5 RID: 23797
	public static class IPatrolActionVerify
	{
		// Token: 0x06027861 RID: 161889 RVA: 0x005687EC File Offset: 0x005669EC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPatrolActionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPatrolActionVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200843C RID: 33852
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014724 RID: 83748
			public static VerifyTableAction <0>__Verify;
		}
	}
}
