using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004600 RID: 17920
	public static class ITakePhoto2TimeConditionVerify
	{
		// Token: 0x0601A327 RID: 107303 RVA: 0x003BB188 File Offset: 0x003B9388
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITakePhoto2TimeConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITakePhoto2TimeConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IHourToHourVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020081AA RID: 33194
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014322 RID: 82722
			public static VerifyTableAction <0>__Verify;
		}
	}
}
