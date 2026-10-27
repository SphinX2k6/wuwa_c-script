using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041B0 RID: 16816
	public static class ITakePhotoTimeConditionVerify
	{
		// Token: 0x06018C2D RID: 101421 RVA: 0x00390990 File Offset: 0x0038EB90
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITakePhotoTimeConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITakePhotoTimeConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IHourToHourVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 8, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007963 RID: 31075
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040132C1 RID: 78529
			public static VerifyTableAction <0>__Verify;
		}
	}
}
