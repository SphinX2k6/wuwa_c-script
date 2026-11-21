using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C60 RID: 19552
	public static class TCsvEffectConfigDataVerify
	{
		// Token: 0x0601DFFB RID: 122875 RVA: 0x004349C0 File Offset: 0x00432BC0
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

		// Token: 0x02008250 RID: 33360
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401441D RID: 82973
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
