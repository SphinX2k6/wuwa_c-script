using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CDE RID: 19678
	public static class ISystemStateConditonVerify
	{
		// Token: 0x0601F3C3 RID: 127939 RVA: 0x0045C1C8 File Offset: 0x0045A3C8
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

		// Token: 0x02007A68 RID: 31336
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013431 RID: 78897
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
