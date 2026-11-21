using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x02004BD6 RID: 19414
	public static class IPerformanceSettingVerify
	{
		// Token: 0x0601DA57 RID: 121431 RVA: 0x0042924C File Offset: 0x0042744C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 10, 4UL, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPerformanceSettingVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPerformanceSettingVerify.<>O.<0>__Verify = new VerifyTableAction(IHighPerformanceModeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008237 RID: 33335
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014402 RID: 82946
			public static VerifyTableAction <0>__Verify;
		}
	}
}
