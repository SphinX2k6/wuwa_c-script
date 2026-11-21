using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043D5 RID: 17365
	public static class IPhotographTargetPlayerVerify
	{
		// Token: 0x06018A8E RID: 101006 RVA: 0x00384380 File Offset: 0x00382580
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPhotographTargetPlayerVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPhotographTargetPlayerVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200815F RID: 33119
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014265 RID: 82533
			public static VerifyTableAction <0>__Verify;
		}
	}
}
