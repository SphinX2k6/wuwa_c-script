using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F76 RID: 16246
	public static class IParkourQuestConditionVerify
	{
		// Token: 0x06017303 RID: 94979 RVA: 0x00358A18 File Offset: 0x00356C18
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IParkourQuestConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IParkourQuestConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 12, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007914 RID: 30996
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040131FF RID: 78335
			public static VerifyTableAction <0>__Verify;
		}
	}
}
