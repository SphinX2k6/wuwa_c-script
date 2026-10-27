using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005284 RID: 21124
	public static class IFlowerPollutionPointLightConfigVerify
	{
		// Token: 0x06022686 RID: 140934 RVA: 0x004C514C File Offset: 0x004C334C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFlowerPollutionPointLightConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFlowerPollutionPointLightConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IPointLightOperationsVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B28 RID: 31528
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013563 RID: 79203
			public static VerifyTableAction <0>__Verify;
		}
	}
}
