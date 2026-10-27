using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x0200476E RID: 18286
	public static class IPerformanceSettingVerify
	{
		// Token: 0x0601C282 RID: 115330 RVA: 0x003FCFB0 File Offset: 0x003FB1B0
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

		// Token: 0x020079EE RID: 31214
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401339B RID: 78747
			public static VerifyTableAction <0>__Verify;
		}
	}
}
