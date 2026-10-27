using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D2A RID: 15658
	public static class IAwakeAndLoadEntityConditionVerify
	{
		// Token: 0x060159D8 RID: 88536 RVA: 0x0031EC5C File Offset: 0x0031CE5C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAwakeAndLoadEntityConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAwakeAndLoadEntityConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 8, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020078B1 RID: 30897
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013127 RID: 78119
			public static VerifyTableAction <0>__Verify;
		}
	}
}
