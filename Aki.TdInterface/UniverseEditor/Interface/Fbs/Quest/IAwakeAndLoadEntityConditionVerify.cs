using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004141 RID: 16705
	public static class IAwakeAndLoadEntityConditionVerify
	{
		// Token: 0x06016F10 RID: 93968 RVA: 0x00345ED4 File Offset: 0x003440D4
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

		// Token: 0x020080F5 RID: 33013
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014183 RID: 82307
			public static VerifyTableAction <0>__Verify;
		}
	}
}
