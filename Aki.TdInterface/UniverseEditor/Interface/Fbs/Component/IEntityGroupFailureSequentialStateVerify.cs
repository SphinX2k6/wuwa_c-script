using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005188 RID: 20872
	public static class IEntityGroupFailureSequentialStateVerify
	{
		// Token: 0x06021C04 RID: 138244 RVA: 0x004AED48 File Offset: 0x004ACF48
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityGroupFailureSequentialStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityGroupFailureSequentialStateVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityStateConditionVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007AFC RID: 31484
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401351F RID: 79135
			public static VerifyTableAction <0>__Verify;
		}
	}
}
