using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058FC RID: 22780
	public static class IHitBulletTypeCrystalAttackVerify
	{
		// Token: 0x0602502D RID: 151597 RVA: 0x005146C0 File Offset: 0x005128C0
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

		// Token: 0x020083B2 RID: 33714
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014627 RID: 83495
			public static VerifyTableAction <0>__Verify;
		}
	}
}
