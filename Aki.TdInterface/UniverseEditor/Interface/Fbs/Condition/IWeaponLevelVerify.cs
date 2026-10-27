using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D1D RID: 19741
	public static class IWeaponLevelVerify
	{
		// Token: 0x0601F55D RID: 128349 RVA: 0x0045E870 File Offset: 0x0045CA70
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

		// Token: 0x02007A6A RID: 31338
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013433 RID: 78899
			public static VerifyTableAction <0>__Verify;
		}
	}
}
