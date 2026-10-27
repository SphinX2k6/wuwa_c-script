using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041A7 RID: 16807
	public static class ITakePhoto2TimeConditionVerify
	{
		// Token: 0x06018BD1 RID: 101329 RVA: 0x0038FD34 File Offset: 0x0038DF34
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

		// Token: 0x02007961 RID: 31073
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040132BC RID: 78524
			public static VerifyTableAction <0>__Verify;
		}
	}
}
