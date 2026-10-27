using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C48 RID: 15432
	public static class ISphereTriggerTipShapeVerify
	{
		// Token: 0x06015538 RID: 87352 RVA: 0x00315F94 File Offset: 0x00314194
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

		// Token: 0x020078A5 RID: 30885
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013114 RID: 78100
			public static VerifyTableAction <0>__Verify;
		}
	}
}
