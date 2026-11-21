using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C14 RID: 23572
	public static class INpcUiInteractOnDollGrabDeliveryVerify
	{
		// Token: 0x06026FB7 RID: 159671 RVA: 0x00556418 File Offset: 0x00554618
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = INpcUiInteractOnDollGrabDeliveryVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INpcUiInteractOnDollGrabDeliveryVerify.<>O.<0>__Verify = new VerifyTableAction(IOnDollGrabDeliveryPerformVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = INpcUiInteractOnDollGrabDeliveryVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (INpcUiInteractOnDollGrabDeliveryVerify.<>O.<0>__Verify = new VerifyTableAction(IOnDollGrabDeliveryPerformVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = INpcUiInteractOnDollGrabDeliveryVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (INpcUiInteractOnDollGrabDeliveryVerify.<>O.<0>__Verify = new VerifyTableAction(IOnDollGrabDeliveryPerformVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 12;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = INpcUiInteractOnDollGrabDeliveryVerify.<>O.<0>__Verify) == null)
							{
								verifyAction4 = (INpcUiInteractOnDollGrabDeliveryVerify.<>O.<0>__Verify = new VerifyTableAction(IOnDollGrabDeliveryPerformVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02008419 RID: 33817
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040146F0 RID: 83696
			public static VerifyTableAction <0>__Verify;
		}
	}
}
