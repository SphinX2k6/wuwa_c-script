using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004BF7 RID: 19447
	public static class IEffectConfigMonsterDeathGroupVerify
	{
		// Token: 0x0601DB47 RID: 121671 RVA: 0x0042ADAC File Offset: 0x00428FAC
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

		// Token: 0x0200823A RID: 33338
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014405 RID: 82949
			public static VerifyTableAction <0>__Verify;
		}
	}
}
