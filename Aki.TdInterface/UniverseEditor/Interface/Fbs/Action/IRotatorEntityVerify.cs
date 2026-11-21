using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200768C RID: 30348
	public static class IRotatorEntityVerify
	{
		// Token: 0x060353CF RID: 218063 RVA: 0x00724EB8 File Offset: 0x007230B8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IRotatorEntityVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRotatorEntityVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086A9 RID: 34473
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A9D RID: 84637
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
