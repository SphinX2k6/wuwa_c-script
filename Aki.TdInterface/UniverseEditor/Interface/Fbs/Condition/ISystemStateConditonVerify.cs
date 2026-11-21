using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051DA RID: 20954
	public static class ISystemStateConditonVerify
	{
		// Token: 0x06021008 RID: 135176 RVA: 0x00490118 File Offset: 0x0048E318
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISystemStateConditonVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISystemStateConditonVerify.<>O.<0>__Verify = new VerifyUnionAction(TCheckSystemStateVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020082BA RID: 33466
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144A1 RID: 83105
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
