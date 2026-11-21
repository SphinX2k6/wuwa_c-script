using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004609 RID: 17929
	public static class ITakePhotoTimeConditionVerify
	{
		// Token: 0x0601A383 RID: 107395 RVA: 0x003BBDE4 File Offset: 0x003B9FE4
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

		// Token: 0x020081AC RID: 33196
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014327 RID: 82727
			public static VerifyTableAction <0>__Verify;
		}
	}
}
