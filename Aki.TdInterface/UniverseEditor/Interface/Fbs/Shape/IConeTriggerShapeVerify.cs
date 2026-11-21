using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004012 RID: 16402
	public static class IConeTriggerShapeVerify
	{
		// Token: 0x06016794 RID: 92052 RVA: 0x00337B0C File Offset: 0x00335D0C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IConeTriggerShapeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IConeTriggerShapeVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020080DE RID: 32990
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014164 RID: 82276
			public static VerifyTableAction <0>__Verify;
		}
	}
}
