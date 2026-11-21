using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005914 RID: 22804
	public static class IHitLogicActionByHitTypeVerify
	{
		// Token: 0x0602512D RID: 151853 RVA: 0x00516B94 File Offset: 0x00514D94
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

		// Token: 0x020083B5 RID: 33717
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401462F RID: 83503
			public static VerifyTableAction <0>__Verify;
		}
	}
}
