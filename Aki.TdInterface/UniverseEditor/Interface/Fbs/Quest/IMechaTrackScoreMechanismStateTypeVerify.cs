using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004369 RID: 17257
	public static class IMechaTrackScoreMechanismStateTypeVerify
	{
		// Token: 0x060185CF RID: 99791 RVA: 0x00379640 File Offset: 0x00377840
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMechaTrackScoreMechanismStateTypeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMechaTrackScoreMechanismStateTypeVerify.<>O.<0>__Verify = new VerifyTableAction(IStaticEntitiyMatchVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200814F RID: 33103
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401423B RID: 82491
			public static VerifyTableAction <0>__Verify;
		}
	}
}
