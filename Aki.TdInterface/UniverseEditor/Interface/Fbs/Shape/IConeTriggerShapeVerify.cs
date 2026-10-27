using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C06 RID: 15366
	public static class IConeTriggerShapeVerify
	{
		// Token: 0x0601529E RID: 86686 RVA: 0x00310F84 File Offset: 0x0030F184
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

		// Token: 0x0200789A RID: 30874
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013108 RID: 78088
			public static VerifyTableAction <0>__Verify;
		}
	}
}
