using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047F8 RID: 18424
	public static class TCsvEffectConfigDataVerify
	{
		// Token: 0x0601C7FE RID: 116734 RVA: 0x00408070 File Offset: 0x00406270
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = TCsvEffectConfigDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (TCsvEffectConfigDataVerify.<>O.<0>__Verify = new VerifyUnionAction(IEffectConfigBase_UnionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A07 RID: 31239
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133B6 RID: 78774
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
