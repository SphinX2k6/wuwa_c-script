using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FB1 RID: 20401
	public static class ICollectAnimalConfigVerify
	{
		// Token: 0x06020792 RID: 133010 RVA: 0x004849F0 File Offset: 0x00482BF0
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

		// Token: 0x02007AB4 RID: 31412
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134A2 RID: 79010
			public static VerifyTableAction <0>__Verify;
		}
	}
}
