using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200550D RID: 21773
	public static class ICollectAnimalConfigVerify
	{
		// Token: 0x06022686 RID: 140934 RVA: 0x004BDED4 File Offset: 0x004BC0D4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICollectAnimalConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICollectAnimalConfigVerify.<>O.<0>__Verify = new VerifyTableAction(ICollectAnimalPartsConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200830E RID: 33550
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014520 RID: 83232
			public static VerifyTableAction <0>__Verify;
		}
	}
}
