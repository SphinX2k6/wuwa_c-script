using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D66 RID: 23910
	public static class IPointGroupByLayerVerify
	{
		// Token: 0x06027CE4 RID: 163044 RVA: 0x00572118 File Offset: 0x00570318
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPointGroupByLayerVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPointGroupByLayerVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IPointGroupByLayerVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IPointGroupByLayerVerify.<>O.<1>__Verify = new VerifyTableAction(IParkourPointLayerConfigVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200844B RID: 33867
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014740 RID: 83776
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014741 RID: 83777
			public static VerifyTableAction <1>__Verify;
		}
	}
}
