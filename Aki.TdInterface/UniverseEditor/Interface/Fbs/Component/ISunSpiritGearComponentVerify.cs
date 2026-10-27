using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059FA RID: 23034
	public static class ISunSpiritGearComponentVerify
	{
		// Token: 0x06027183 RID: 160131 RVA: 0x00560DD0 File Offset: 0x0055EFD0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISunSpiritGearComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISunSpiritGearComponentVerify.<>O.<0>__Verify = new VerifyUnionAction(TSunSpiritGearPerformConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C49 RID: 31817
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013742 RID: 79682
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
