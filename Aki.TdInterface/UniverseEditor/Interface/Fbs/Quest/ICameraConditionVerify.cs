using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D42 RID: 15682
	public static class ICameraConditionVerify
	{
		// Token: 0x06015AC4 RID: 88772 RVA: 0x003208CC File Offset: 0x0031EACC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICameraConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICameraConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020078B4 RID: 30900
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401312C RID: 78124
			public static VerifyTableAction <0>__Verify;
		}
	}
}
