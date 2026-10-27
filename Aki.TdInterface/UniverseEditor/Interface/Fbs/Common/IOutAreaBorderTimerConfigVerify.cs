using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E20 RID: 24096
	public static class IOutAreaBorderTimerConfigVerify
	{
		// Token: 0x0602941D RID: 168989 RVA: 0x005A8AA0 File Offset: 0x005A6CA0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IOutAreaBorderTimerConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IOutAreaBorderTimerConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IOutAreaBorderDownTimeTextTipVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IOutAreaBorderTimerConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IOutAreaBorderTimerConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IOutAreaBorderBuffEffectVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007CB1 RID: 31921
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137DE RID: 79838
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040137DF RID: 79839
			public static VerifyTableAction <1>__Verify;
		}
	}
}
