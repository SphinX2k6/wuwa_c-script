using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x0200401E RID: 16414
	public static class ICylinderTriggerShapeVerify
	{
		// Token: 0x06016818 RID: 92184 RVA: 0x00338A84 File Offset: 0x00336C84
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICylinderTriggerShapeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICylinderTriggerShapeVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020080E0 RID: 32992
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014166 RID: 82278
			public static VerifyTableAction <0>__Verify;
		}
	}
}
