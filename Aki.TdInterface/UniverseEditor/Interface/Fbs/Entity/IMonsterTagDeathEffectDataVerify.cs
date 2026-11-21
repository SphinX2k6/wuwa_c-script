using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C54 RID: 19540
	public static class IMonsterTagDeathEffectDataVerify
	{
		// Token: 0x0601DF90 RID: 122768 RVA: 0x00433BE0 File Offset: 0x00431DE0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMonsterTagDeathEffectDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMonsterTagDeathEffectDataVerify.<>O.<0>__Verify = new VerifyTableAction(IEffectConfigMonsterDeathVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200824D RID: 33357
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401441A RID: 82970
			public static VerifyTableAction <0>__Verify;
		}
	}
}
