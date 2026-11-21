using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004057 RID: 16471
	public static class ISphereTriggerTipShapeVerify
	{
		// Token: 0x06016A4C RID: 92748 RVA: 0x0033CE34 File Offset: 0x0033B034
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISphereTriggerTipShapeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISphereTriggerTipShapeVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020080E9 RID: 33001
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014170 RID: 82288
			public static VerifyTableAction <0>__Verify;
		}
	}
}
