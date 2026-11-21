using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FFB RID: 24571
	public static class ISuccessConditionSpecificTargetStateVerify
	{
		// Token: 0x0602966D RID: 169581 RVA: 0x005A6920 File Offset: 0x005A4B20
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISuccessConditionSpecificTargetStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISuccessConditionSpecificTargetStateVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityStateConditionVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020084B4 RID: 33972
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147E1 RID: 83937
			public static VerifyTableAction <0>__Verify;
		}
	}
}
