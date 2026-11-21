using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005219 RID: 21017
	public static class IWeaponLevelVerify
	{
		// Token: 0x060211A4 RID: 135588 RVA: 0x00492800 File Offset: 0x00490A00
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IWeaponLevelVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWeaponLevelVerify.<>O.<0>__Verify = new VerifyTableAction(ISpecifyRoleWeaponLevelVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020082BC RID: 33468
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144A3 RID: 83107
			public static VerifyTableAction <0>__Verify;
		}
	}
}
