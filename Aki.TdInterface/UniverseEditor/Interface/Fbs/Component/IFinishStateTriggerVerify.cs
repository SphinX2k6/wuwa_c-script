using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005257 RID: 21079
	public static class IFinishStateTriggerVerify
	{
		// Token: 0x0602249E RID: 140446 RVA: 0x004C126C File Offset: 0x004BF46C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFinishStateTriggerVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFinishStateTriggerVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityGroupConditionVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B1F RID: 31519
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013556 RID: 79190
			public static VerifyTableAction <0>__Verify;
		}
	}
}
