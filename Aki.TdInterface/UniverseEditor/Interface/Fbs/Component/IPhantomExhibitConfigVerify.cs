using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D33 RID: 23859
	public static class IPhantomExhibitConfigVerify
	{
		// Token: 0x06027AAB RID: 162475 RVA: 0x0056D388 File Offset: 0x0056B588
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPhantomExhibitConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPhantomExhibitConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IPhantomExhibitConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IPhantomExhibitConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IExhibitEffectVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008442 RID: 33858
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014730 RID: 83760
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014731 RID: 83761
			public static VerifyTableAction <1>__Verify;
		}
	}
}
