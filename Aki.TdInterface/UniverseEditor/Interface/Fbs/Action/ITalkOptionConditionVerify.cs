using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007324 RID: 29476
	public static class ITalkOptionConditionVerify
	{
		// Token: 0x060357F7 RID: 219127 RVA: 0x00749F70 File Offset: 0x00748170
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITalkOptionConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITalkOptionConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E96 RID: 32406
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013BCE RID: 80846
			public static VerifyTableAction <0>__Verify;
		}
	}
}
