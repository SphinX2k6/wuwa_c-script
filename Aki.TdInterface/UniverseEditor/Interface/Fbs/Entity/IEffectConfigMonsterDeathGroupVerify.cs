using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x0200478F RID: 18319
	public static class IEffectConfigMonsterDeathGroupVerify
	{
		// Token: 0x0601C372 RID: 115570 RVA: 0x003FEB10 File Offset: 0x003FCD10
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEffectConfigMonsterDeathGroupVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEffectConfigMonsterDeathGroupVerify.<>O.<0>__Verify = new VerifyTableAction(IMonsterTagDeathEffectDataVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079F1 RID: 31217
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401339E RID: 78750
			public static VerifyTableAction <0>__Verify;
		}
	}
}
