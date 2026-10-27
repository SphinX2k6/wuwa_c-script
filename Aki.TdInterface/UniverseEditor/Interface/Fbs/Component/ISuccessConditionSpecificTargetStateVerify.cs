using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059EE RID: 23022
	public static class ISuccessConditionSpecificTargetStateVerify
	{
		// Token: 0x060270F5 RID: 159989 RVA: 0x0055F95C File Offset: 0x0055DB5C
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

		// Token: 0x02007C45 RID: 31813
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401373D RID: 79677
			public static VerifyTableAction <0>__Verify;
		}
	}
}
