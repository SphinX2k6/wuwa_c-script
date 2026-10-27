using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047EC RID: 18412
	public static class IMonsterTagDeathEffectDataVerify
	{
		// Token: 0x0601C793 RID: 116627 RVA: 0x00407290 File Offset: 0x00405490
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

		// Token: 0x02007A04 RID: 31236
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133B3 RID: 78771
			public static VerifyTableAction <0>__Verify;
		}
	}
}
