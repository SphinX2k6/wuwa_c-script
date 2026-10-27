using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C18 RID: 19480
	public static class IEntityGroupConditionVerify
	{
		// Token: 0x0601EDC4 RID: 126404 RVA: 0x00451FA8 File Offset: 0x004501A8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityGroupConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityGroupConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityEventConditionVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A5D RID: 31325
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013425 RID: 78885
			public static VerifyTableAction <0>__Verify;
		}
	}
}
