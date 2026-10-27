using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051B5 RID: 20917
	public static class IEntityStateAudioComponentVerify
	{
		// Token: 0x06021DE3 RID: 138723 RVA: 0x004B29BC File Offset: 0x004B0BBC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IEntityStateAudioComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityStateAudioComponentVerify.<>O.<0>__Verify = new VerifyUnionAction(TAkEventTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short offsetId = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IEntityStateAudioComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IEntityStateAudioComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IEntityStateAudioConfigVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007B03 RID: 31491
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013527 RID: 79143
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04013528 RID: 79144
			public static VerifyTableAction <1>__Verify;
		}
	}
}
