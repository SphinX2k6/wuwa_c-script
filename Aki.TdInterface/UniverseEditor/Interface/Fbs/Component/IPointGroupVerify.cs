using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D63 RID: 23907
	public static class IPointGroupVerify
	{
		// Token: 0x06027CC4 RID: 163012 RVA: 0x00571C68 File Offset: 0x0056FE68
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPointGroupVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPointGroupVerify.<>O.<0>__Verify = new VerifyTableAction(IPointGroupByLayerVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IPointGroupVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IPointGroupVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200844A RID: 33866
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401473E RID: 83774
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401473F RID: 83775
			public static VerifyTableAction <1>__Verify;
		}
	}
}
