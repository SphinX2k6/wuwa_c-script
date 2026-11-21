using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057EC RID: 22508
	public static class IFlowerPollutionPointLightConfigVerify
	{
		// Token: 0x06024620 RID: 149024 RVA: 0x004FFCBC File Offset: 0x004FDEBC
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

		// Token: 0x02008383 RID: 33667
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145E3 RID: 83427
			public static VerifyTableAction <0>__Verify;
		}
	}
}
