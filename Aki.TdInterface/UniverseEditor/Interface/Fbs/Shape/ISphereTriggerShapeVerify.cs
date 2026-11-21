using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004054 RID: 16468
	public static class ISphereTriggerShapeVerify
	{
		// Token: 0x06016A32 RID: 92722 RVA: 0x0033CB1C File Offset: 0x0033AD1C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISphereTriggerShapeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISphereTriggerShapeVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020080E8 RID: 33000
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401416F RID: 82287
			public static VerifyTableAction <0>__Verify;
		}
	}
}
