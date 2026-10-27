using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006277 RID: 25207
	public static class ICameraDataVerify
	{
		// Token: 0x0602B822 RID: 178210 RVA: 0x005FD964 File Offset: 0x005FBB64
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

		// Token: 0x02007CFF RID: 31999
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401385F RID: 79967
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013860 RID: 79968
			public static VerifyTableAction <1>__Verify;
		}
	}
}
