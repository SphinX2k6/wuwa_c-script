using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044F0 RID: 17648
	public static class ILevelPlayExploratoryConfigVerify
	{
		// Token: 0x0601A7C4 RID: 108484 RVA: 0x003C8984 File Offset: 0x003C6B84
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILevelPlayExploratoryConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILevelPlayExploratoryConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079B0 RID: 31152
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401334A RID: 78666
			public static VerifyTableAction <0>__Verify;
		}
	}
}
