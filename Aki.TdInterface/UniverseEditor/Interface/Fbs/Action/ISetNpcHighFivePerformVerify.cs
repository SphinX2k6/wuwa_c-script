using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200703C RID: 28732
	public static class ISetNpcHighFivePerformVerify
	{
		// Token: 0x06032D4D RID: 208205 RVA: 0x006DB3E8 File Offset: 0x006D95E8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISetNpcHighFivePerformVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetNpcHighFivePerformVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayerInitiatorVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E45 RID: 32325
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A10 RID: 80400
			public static VerifyTableAction <0>__Verify;
		}
	}
}
