using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050F2 RID: 20722
	public static class IDynamicPortalCreateModeVerify
	{
		// Token: 0x060215F2 RID: 136690 RVA: 0x004A258C File Offset: 0x004A078C
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

		// Token: 0x02007AE5 RID: 31461
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134FA RID: 79098
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040134FB RID: 79099
			public static VerifyTableAction <1>__Verify;
		}
	}
}
