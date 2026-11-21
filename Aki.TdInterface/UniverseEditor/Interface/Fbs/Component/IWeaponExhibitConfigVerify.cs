using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006186 RID: 24966
	public static class IWeaponExhibitConfigVerify
	{
		// Token: 0x0602A6C4 RID: 173764 RVA: 0x005C9948 File Offset: 0x005C7B48
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IWeaponExhibitConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWeaponExhibitConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IWeaponExhibitConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IWeaponExhibitConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IExhibitEffectVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020084EE RID: 34030
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014849 RID: 84041
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401484A RID: 84042
			public static VerifyTableAction <1>__Verify;
		}
	}
}
