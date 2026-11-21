using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004462 RID: 17506
	public static class IQuestScheduleDistanceValueVerify
	{
		// Token: 0x06019231 RID: 102961 RVA: 0x00395EF0 File Offset: 0x003940F0
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

		// Token: 0x0200817D RID: 33149
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040142AC RID: 82604
			public static VerifyTableAction <0>__Verify;
		}
	}
}
