using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005657 RID: 22103
	public static class IDynamicPortalCreateModeVerify
	{
		// Token: 0x06023546 RID: 144710 RVA: 0x004DC518 File Offset: 0x004DA718
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDynamicPortalCreateModeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDynamicPortalCreateModeVerify.<>O.<0>__Verify = new VerifyTableAction(IDynamicPortalConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IDynamicPortalCreateModeVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IDynamicPortalCreateModeVerify.<>O.<0>__Verify = new VerifyTableAction(IDynamicPortalConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
					{
						short offsetId3 = 12;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IDynamicPortalCreateModeVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (IDynamicPortalCreateModeVerify.<>O.<1>__Verify = new VerifyTableAction(IPortalRenderConfigVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0200833F RID: 33599
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014578 RID: 83320
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014579 RID: 83321
			public static VerifyTableAction <1>__Verify;
		}
	}
}
