using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A89 RID: 19081
	public static class ICheckIsEntityTimeScaleEnabledVerify
	{
		// Token: 0x0601DECB RID: 122571 RVA: 0x00433E4C File Offset: 0x0043204C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICheckIsEntityTimeScaleEnabledVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckIsEntityTimeScaleEnabledVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A37 RID: 31287
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133FB RID: 78843
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
