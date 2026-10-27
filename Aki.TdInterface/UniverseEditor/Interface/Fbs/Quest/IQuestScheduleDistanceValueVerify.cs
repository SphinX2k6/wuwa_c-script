using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004021 RID: 16417
	public static class IQuestScheduleDistanceValueVerify
	{
		// Token: 0x06017B98 RID: 97176 RVA: 0x0036C0FC File Offset: 0x0036A2FC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IQuestScheduleDistanceValueVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQuestScheduleDistanceValueVerify.<>O.<0>__Verify = new VerifyTableAction(IPosAVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007936 RID: 31030
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013249 RID: 78409
			public static VerifyTableAction <0>__Verify;
		}
	}
}
