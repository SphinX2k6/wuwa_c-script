using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004955 RID: 18773
	public static class ILevelPlayActiveVerify
	{
		// Token: 0x0601BF77 RID: 114551 RVA: 0x003F4820 File Offset: 0x003F2A20
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILevelPlayActiveVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILevelPlayActiveVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020081F8 RID: 33272
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143B0 RID: 82864
			public static VerifyTableAction <0>__Verify;
		}
	}
}
