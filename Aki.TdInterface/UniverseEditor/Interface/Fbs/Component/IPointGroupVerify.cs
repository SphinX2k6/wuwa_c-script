using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200575C RID: 22364
	public static class IPointGroupVerify
	{
		// Token: 0x060257A4 RID: 153508 RVA: 0x0052BADC File Offset: 0x00529CDC
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

		// Token: 0x02007BDC RID: 31708
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401369E RID: 79518
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401369F RID: 79519
			public static VerifyTableAction <1>__Verify;
		}
	}
}
