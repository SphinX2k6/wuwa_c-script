using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043DE RID: 17374
	public static class IPhotoTargetVerify
	{
		// Token: 0x06018AD2 RID: 101074 RVA: 0x00384AA8 File Offset: 0x00382CA8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPhotoTargetVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPhotoTargetVerify.<>O.<0>__Verify = new VerifyTableAction(ISetVarVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008160 RID: 33120
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014266 RID: 82534
			public static VerifyTableAction <0>__Verify;
		}
	}
}
