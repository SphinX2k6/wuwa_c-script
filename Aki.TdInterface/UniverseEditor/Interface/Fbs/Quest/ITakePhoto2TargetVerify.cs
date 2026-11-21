using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045E8 RID: 17896
	public static class ITakePhoto2TargetVerify
	{
		// Token: 0x0601A264 RID: 107108 RVA: 0x003B99A8 File Offset: 0x003B7BA8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITakePhoto2TargetVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITakePhoto2TargetVerify.<>O.<0>__Verify = new VerifyTableAction(ITakePhoto2TargetCameraDistanceConditionVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020081A7 RID: 33191
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401431B RID: 82715
			public static VerifyTableAction <0>__Verify;
		}
	}
}
