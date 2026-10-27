using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075FA RID: 30202
	public static class IWaitBattleConditionVerify
	{
		// Token: 0x06037049 RID: 225353 RVA: 0x00777029 File Offset: 0x00775229
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IWaitBattleConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWaitBattleConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IDetectBattleTagVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007EDA RID: 32474
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013C2C RID: 80940
			public static VerifyTableAction <0>__Verify;
		}
	}
}
