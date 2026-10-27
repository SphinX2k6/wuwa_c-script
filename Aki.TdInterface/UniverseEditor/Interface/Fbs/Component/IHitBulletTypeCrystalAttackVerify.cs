using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005376 RID: 21366
	public static class IHitBulletTypeCrystalAttackVerify
	{
		// Token: 0x06022F79 RID: 143225 RVA: 0x004D77EC File Offset: 0x004D59EC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IHitBulletTypeCrystalAttackVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IHitBulletTypeCrystalAttackVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B53 RID: 31571
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040135A2 RID: 79266
			public static VerifyTableAction <0>__Verify;
		}
	}
}
