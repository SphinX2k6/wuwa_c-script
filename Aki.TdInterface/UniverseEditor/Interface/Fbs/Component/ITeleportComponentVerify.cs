using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200605B RID: 24667
	public static class ITeleportComponentVerify
	{
		// Token: 0x06029A7D RID: 170621 RVA: 0x005AFC84 File Offset: 0x005ADE84
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITeleportComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITeleportComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IPosAVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITeleportComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITeleportComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IGravityFlipTeleportConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020084C4 RID: 33988
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147FF RID: 83967
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014800 RID: 83968
			public static VerifyTableAction <1>__Verify;
		}
	}
}
