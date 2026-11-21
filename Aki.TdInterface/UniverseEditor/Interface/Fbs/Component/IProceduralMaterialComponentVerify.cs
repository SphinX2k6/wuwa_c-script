using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D90 RID: 23952
	public static class IProceduralMaterialComponentVerify
	{
		// Token: 0x06027E46 RID: 163398 RVA: 0x00574D74 File Offset: 0x00572F74
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IProceduralMaterialComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IProceduralMaterialComponentVerify.<>O.<0>__Verify = new VerifyTableAction(ICustomPrimitiveDataConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008454 RID: 33876
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401474B RID: 83787
			public static VerifyTableAction <0>__Verify;
		}
	}
}
