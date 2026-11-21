using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005552 RID: 21842
	public static class IConditionHitConfigVerify
	{
		// Token: 0x06022A82 RID: 141954 RVA: 0x004C5F5C File Offset: 0x004C415C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IConditionHitConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IConditionHitConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 6, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008318 RID: 33560
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401452E RID: 83246
			public static VerifyTableAction <0>__Verify;
		}
	}
}
