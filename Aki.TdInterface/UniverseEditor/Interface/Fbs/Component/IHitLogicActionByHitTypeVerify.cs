using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200538E RID: 21390
	public static class IHitLogicActionByHitTypeVerify
	{
		// Token: 0x06023079 RID: 143481 RVA: 0x004D9CC0 File Offset: 0x004D7EC0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IHitLogicActionByHitTypeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IHitLogicActionByHitTypeVerify.<>O.<0>__Verify = new VerifyTableAction(IActionByHitTypeConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B56 RID: 31574
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040135AA RID: 79274
			public static VerifyTableAction <0>__Verify;
		}
	}
}
