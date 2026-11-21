using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068E8 RID: 26856
	public static class ICameraDataVerify
	{
		// Token: 0x0602DF83 RID: 188291 RVA: 0x0064876C File Offset: 0x0064696C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICameraDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICameraDataVerify.<>O.<0>__Verify = new VerifyTableAction(IFlowTemplateModeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ICameraDataVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ICameraDataVerify.<>O.<1>__Verify = new VerifyTableAction(ISetCameraAnimVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008572 RID: 34162
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014907 RID: 84231
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014908 RID: 84232
			public static VerifyTableAction <1>__Verify;
		}
	}
}
