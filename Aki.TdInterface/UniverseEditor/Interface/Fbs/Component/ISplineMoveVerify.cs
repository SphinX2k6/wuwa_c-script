using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005985 RID: 22917
	public static class ISplineMoveVerify
	{
		// Token: 0x06026CE9 RID: 158953 RVA: 0x005578DC File Offset: 0x00555ADC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISplineMoveVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISplineMoveVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityStateConditionVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C38 RID: 31800
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013724 RID: 79652
			public static VerifyTableAction <0>__Verify;
		}
	}
}
