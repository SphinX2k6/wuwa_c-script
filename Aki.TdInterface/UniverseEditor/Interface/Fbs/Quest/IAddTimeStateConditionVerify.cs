using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004111 RID: 16657
	public static class IAddTimeStateConditionVerify
	{
		// Token: 0x06016D5A RID: 93530 RVA: 0x00342800 File Offset: 0x00340A00
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAddTimeStateConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAddTimeStateConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityStateConditionVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020080F1 RID: 33009
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401417C RID: 82300
			public static VerifyTableAction <0>__Verify;
		}
	}
}
