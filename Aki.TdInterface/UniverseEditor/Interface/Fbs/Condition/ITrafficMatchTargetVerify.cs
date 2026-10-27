using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CFC RID: 19708
	public static class ITrafficMatchTargetVerify
	{
		// Token: 0x0601F483 RID: 128131 RVA: 0x0045D3B0 File Offset: 0x0045B5B0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITrafficMatchTargetVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITrafficMatchTargetVerify.<>O.<0>__Verify = new VerifyTableAction(ITrafficMatchTargetByEntityLogicVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A69 RID: 31337
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013432 RID: 78898
			public static VerifyTableAction <0>__Verify;
		}
	}
}
