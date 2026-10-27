using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005598 RID: 21912
	public static class IMonsterPerformConfigVerify
	{
		// Token: 0x06024464 RID: 148580 RVA: 0x00502221 File Offset: 0x00500421
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMonsterPerformConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMonsterPerformConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IMonsterShowOnDeathEffectVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B95 RID: 31637
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013622 RID: 79394
			public static VerifyTableAction <0>__Verify;
		}
	}
}
