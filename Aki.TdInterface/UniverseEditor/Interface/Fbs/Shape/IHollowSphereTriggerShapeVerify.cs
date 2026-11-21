using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004030 RID: 16432
	public static class IHollowSphereTriggerShapeVerify
	{
		// Token: 0x060168E4 RID: 92388 RVA: 0x0033A300 File Offset: 0x00338500
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IHollowSphereTriggerShapeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IHollowSphereTriggerShapeVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020080E3 RID: 32995
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014169 RID: 82281
			public static VerifyTableAction <0>__Verify;
		}
	}
}
