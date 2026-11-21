using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006007 RID: 24583
	public static class ISunSpiritGearComponentVerify
	{
		// Token: 0x060296FB RID: 169723 RVA: 0x005A7D94 File Offset: 0x005A5F94
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

		// Token: 0x020084B8 RID: 33976
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147E6 RID: 83942
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
