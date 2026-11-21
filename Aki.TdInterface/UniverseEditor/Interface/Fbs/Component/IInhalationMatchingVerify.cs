using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005986 RID: 22918
	public static class IInhalationMatchingVerify
	{
		// Token: 0x060255CE RID: 153038 RVA: 0x00520B0C File Offset: 0x0051ED0C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IInhalationMatchingVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IInhalationMatchingVerify.<>O.<0>__Verify = new VerifyTableAction(ICategoryMatchingConditionVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020083C5 RID: 33733
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401464F RID: 83535
			public static VerifyTableAction <0>__Verify;
		}
	}
}
