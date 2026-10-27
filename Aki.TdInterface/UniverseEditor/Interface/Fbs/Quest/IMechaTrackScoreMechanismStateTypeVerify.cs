using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F2B RID: 16171
	public static class IMechaTrackScoreMechanismStateTypeVerify
	{
		// Token: 0x06016F77 RID: 94071 RVA: 0x00350418 File Offset: 0x0034E618
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

		// Token: 0x02007909 RID: 30985
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040131DC RID: 78300
			public static VerifyTableAction <0>__Verify;
		}
	}
}
