using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F94 RID: 16276
	public static class IPhotographTargetPlayerVerify
	{
		// Token: 0x060173FF RID: 95231 RVA: 0x0035A768 File Offset: 0x00358968
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

		// Token: 0x02007918 RID: 31000
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013203 RID: 78339
			public static VerifyTableAction <0>__Verify;
		}
	}
}
