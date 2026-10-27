using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004147 RID: 16711
	public static class IStartBtNodeVerify
	{
		// Token: 0x06018851 RID: 100433 RVA: 0x00388C90 File Offset: 0x00386E90
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 8, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IStartBtNodeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IStartBtNodeVerify.<>O.<0>__Verify = new VerifyTableAction(IFixProcessorVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
				{
					short typeIdVOffset = 16;
					short valueVOffset = 18;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IStartBtNodeVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IStartBtNodeVerify.<>O.<1>__Verify = new VerifyUnionAction(TBtNodeVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007955 RID: 31061
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040132A0 RID: 78496
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040132A1 RID: 78497
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
