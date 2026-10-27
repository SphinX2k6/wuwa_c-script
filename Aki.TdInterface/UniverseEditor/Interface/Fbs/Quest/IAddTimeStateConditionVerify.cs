using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003CFA RID: 15610
	public static class IAddTimeStateConditionVerify
	{
		// Token: 0x06015822 RID: 88098 RVA: 0x0031B588 File Offset: 0x00319788
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAddTimeStateConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAddTimeStateConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityStateConditionVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020078AD RID: 30893
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013120 RID: 78112
			public static VerifyTableAction <0>__Verify;
		}
	}
}
