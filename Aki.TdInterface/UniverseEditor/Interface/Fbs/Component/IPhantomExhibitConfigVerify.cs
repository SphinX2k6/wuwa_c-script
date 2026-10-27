using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200572C RID: 22316
	public static class IPhantomExhibitConfigVerify
	{
		// Token: 0x0602558B RID: 152971 RVA: 0x005271FC File Offset: 0x005253FC
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

		// Token: 0x02007BD4 RID: 31700
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013690 RID: 79504
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013691 RID: 79505
			public static VerifyTableAction <1>__Verify;
		}
	}
}
