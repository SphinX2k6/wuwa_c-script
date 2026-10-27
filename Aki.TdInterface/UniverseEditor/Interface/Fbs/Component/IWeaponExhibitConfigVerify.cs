using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B70 RID: 23408
	public static class IWeaponExhibitConfigVerify
	{
		// Token: 0x06028100 RID: 164096 RVA: 0x00581EB8 File Offset: 0x005800B8
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

		// Token: 0x02007C7D RID: 31869
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137A3 RID: 79779
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040137A4 RID: 79780
			public static VerifyTableAction <1>__Verify;
		}
	}
}
