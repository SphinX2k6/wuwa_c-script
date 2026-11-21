using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x0200402A RID: 16426
	public static class IHollowCylinderTriggerShapeVerify
	{
		// Token: 0x060168A4 RID: 92324 RVA: 0x00339B88 File Offset: 0x00337D88
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IHollowCylinderTriggerShapeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IHollowCylinderTriggerShapeVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020080E2 RID: 32994
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014168 RID: 82280
			public static VerifyTableAction <0>__Verify;
		}
	}
}
