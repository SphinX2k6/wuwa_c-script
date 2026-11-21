using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005504 RID: 21764
	public static class IClientConditionListenerComponentVerify
	{
		// Token: 0x06022618 RID: 140824 RVA: 0x004BCDC8 File Offset: 0x004BAFC8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IClientConditionListenerComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IClientConditionListenerComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IClientConditionListenerVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200830B RID: 33547
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401451C RID: 83228
			public static VerifyTableAction <0>__Verify;
		}
	}
}
