using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007123 RID: 28963
	public static class ISkiConfigTypeVerify
	{
		// Token: 0x060335AC RID: 210348 RVA: 0x006EC22C File Offset: 0x006EA42C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISkiConfigTypeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISkiConfigTypeVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E62 RID: 32354
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A3F RID: 80447
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
