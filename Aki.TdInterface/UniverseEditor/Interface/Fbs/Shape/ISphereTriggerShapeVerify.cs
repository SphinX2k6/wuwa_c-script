using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C45 RID: 15429
	public static class ISphereTriggerShapeVerify
	{
		// Token: 0x0601551E RID: 87326 RVA: 0x00315C7C File Offset: 0x00313E7C
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

		// Token: 0x020078A4 RID: 30884
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013113 RID: 78099
			public static VerifyTableAction <0>__Verify;
		}
	}
}
