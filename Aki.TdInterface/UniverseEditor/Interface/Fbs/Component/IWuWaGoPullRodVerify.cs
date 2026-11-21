using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061E8 RID: 25064
	public static class IWuWaGoPullRodVerify
	{
		// Token: 0x0602AA2E RID: 174638 RVA: 0x005D0508 File Offset: 0x005CE708
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

		// Token: 0x020084FD RID: 34045
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401485D RID: 84061
			public static VerifyTableAction <0>__Verify;
		}
	}
}
