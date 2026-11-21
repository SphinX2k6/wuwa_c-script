using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004958 RID: 18776
	public static class ILevelPlayExploratoryConfigVerify
	{
		// Token: 0x0601BF99 RID: 114585 RVA: 0x003F4C20 File Offset: 0x003F2E20
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

		// Token: 0x020081F9 RID: 33273
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143B1 RID: 82865
			public static VerifyTableAction <0>__Verify;
		}
	}
}
