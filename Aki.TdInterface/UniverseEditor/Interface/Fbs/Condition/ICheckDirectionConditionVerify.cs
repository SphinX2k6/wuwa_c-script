using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049C9 RID: 18889
	public static class ICheckDirectionConditionVerify
	{
		// Token: 0x0601D7E5 RID: 120805 RVA: 0x004275A0 File Offset: 0x004257A0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckDirectionConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckDirectionConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A24 RID: 31268
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133E7 RID: 78823
			public static VerifyTableAction <0>__Verify;
		}
	}
}
