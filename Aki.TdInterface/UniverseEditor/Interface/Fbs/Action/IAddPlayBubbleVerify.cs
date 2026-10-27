using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006136 RID: 24886
	public static class IAddPlayBubbleVerify
	{
		// Token: 0x0602A8DC RID: 174300 RVA: 0x005DBF34 File Offset: 0x005DA134
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAddPlayBubbleVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAddPlayBubbleVerify.<>O.<0>__Verify = new VerifyTableAction(IBubbleIndexVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
				{
					short offsetId2 = 20;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IAddPlayBubbleVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IAddPlayBubbleVerify.<>O.<1>__Verify = new VerifyTableAction(IBubbleRangeCylinderConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007CDD RID: 31965
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013811 RID: 79889
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013812 RID: 79890
			public static VerifyTableAction <1>__Verify;
		}
	}
}
