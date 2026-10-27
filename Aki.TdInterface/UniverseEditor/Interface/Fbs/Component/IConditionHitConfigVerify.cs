using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FF3 RID: 20467
	public static class IConditionHitConfigVerify
	{
		// Token: 0x06020B62 RID: 133986 RVA: 0x0048C50C File Offset: 0x0048A70C
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

		// Token: 0x02007ABE RID: 31422
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134B0 RID: 79024
			public static VerifyTableAction <0>__Verify;
		}
	}
}
