using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C48 RID: 19528
	public static class IItemConditionVerify
	{
		// Token: 0x0601EF52 RID: 126802 RVA: 0x00454A74 File Offset: 0x00452C74
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IItemConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IItemConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IItemConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A61 RID: 31329
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013429 RID: 78889
			public static VerifyTableAction <0>__Verify;
		}
	}
}
