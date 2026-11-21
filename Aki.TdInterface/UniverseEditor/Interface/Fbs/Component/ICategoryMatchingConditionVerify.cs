using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005492 RID: 21650
	public static class ICategoryMatchingConditionVerify
	{
		// Token: 0x06022102 RID: 139522 RVA: 0x004B2064 File Offset: 0x004B0264
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICategoryMatchingConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICategoryMatchingConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IDynamicEntityMatchVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 6, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020082F6 RID: 33526
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144F9 RID: 83193
			public static VerifyTableAction <0>__Verify;
		}
	}
}
