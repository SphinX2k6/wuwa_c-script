using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BD2 RID: 23506
	public static class IWuWaGoPullRodVerify
	{
		// Token: 0x0602846A RID: 164970 RVA: 0x00588A78 File Offset: 0x00586C78
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IWuWaGoPullRodVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWuWaGoPullRodVerify.<>O.<0>__Verify = new VerifyTableAction(IWuWaGoInteractStateActionVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C8C RID: 31884
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137B7 RID: 79799
			public static VerifyTableAction <0>__Verify;
		}
	}
}
