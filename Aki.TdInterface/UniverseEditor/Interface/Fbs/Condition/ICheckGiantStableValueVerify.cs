using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A3B RID: 19003
	public static class ICheckGiantStableValueVerify
	{
		// Token: 0x0601DC0B RID: 121867 RVA: 0x0042F23C File Offset: 0x0042D43C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICheckGiantStableValueVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckGiantStableValueVerify.<>O.<0>__Verify = new VerifyUnionAction(TGiantStableValueVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A32 RID: 31282
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133F6 RID: 78838
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
