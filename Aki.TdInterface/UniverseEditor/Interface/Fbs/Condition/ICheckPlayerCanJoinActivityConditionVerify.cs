using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004ADA RID: 19162
	public static class ICheckPlayerCanJoinActivityConditionVerify
	{
		// Token: 0x0601E19D RID: 123293 RVA: 0x00439018 File Offset: 0x00437218
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckPlayerCanJoinActivityConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckPlayerCanJoinActivityConditionVerify.<>O.<0>__Verify = new VerifyTableAction(ICheckPlayerCanJoinRogueVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A40 RID: 31296
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013404 RID: 78852
			public static VerifyTableAction <0>__Verify;
		}
	}
}
