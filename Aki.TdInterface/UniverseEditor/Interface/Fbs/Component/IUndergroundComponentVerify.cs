using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AFE RID: 23294
	public static class IUndergroundComponentVerify
	{
		// Token: 0x06027C5F RID: 162911 RVA: 0x00578778 File Offset: 0x00576978
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyVectorOfStrings(tablePos, 10, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = IUndergroundComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IUndergroundComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IUndergroundStateInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C71 RID: 31857
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013791 RID: 79761
			public static VerifyTableAction <0>__Verify;
		}
	}
}
