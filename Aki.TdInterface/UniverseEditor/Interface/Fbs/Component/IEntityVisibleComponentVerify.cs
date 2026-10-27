using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051C7 RID: 20935
	public static class IEntityVisibleComponentVerify
	{
		// Token: 0x06021F03 RID: 139011 RVA: 0x004B542C File Offset: 0x004B362C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
			{
				short offsetId = 14;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityVisibleComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityVisibleComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IVisibleConditionGroupVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B09 RID: 31497
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013533 RID: 79155
			public static VerifyTableAction <0>__Verify;
		}
	}
}
