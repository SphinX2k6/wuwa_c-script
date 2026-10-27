using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200656F RID: 25967
	public static class IDeliverItemProbeCollectiblesConfigVerify
	{
		// Token: 0x0602D0D7 RID: 184535 RVA: 0x0062E970 File Offset: 0x0062CB70
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDeliverItemProbeCollectiblesConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDeliverItemProbeCollectiblesConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IHandInItemViewStyleVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IDeliverItemProbeCollectiblesConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IDeliverItemProbeCollectiblesConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IItemCellIndependentDeliverTypeVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 8;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IDeliverItemProbeCollectiblesConfigVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IDeliverItemProbeCollectiblesConfigVerify.<>O.<2>__Verify = new VerifyTableAction(IPlaceholderCollectibleMarkerTypeVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007D3C RID: 32060
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138AF RID: 80047
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040138B0 RID: 80048
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040138B1 RID: 80049
			public static VerifyTableAction <2>__Verify;
		}
	}
}
