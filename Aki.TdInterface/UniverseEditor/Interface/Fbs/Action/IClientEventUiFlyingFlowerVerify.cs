using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063B7 RID: 25527
	public static class IClientEventUiFlyingFlowerVerify
	{
		// Token: 0x0602C286 RID: 180870 RVA: 0x006103A8 File Offset: 0x0060E5A8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IClientEventUiFlyingFlowerVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IClientEventUiFlyingFlowerVerify.<>O.<0>__Verify = new VerifyTableAction(IClientEventFlyingFlowerUpdateSubtitleVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D1C RID: 32028
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013887 RID: 80007
			public static VerifyTableAction <0>__Verify;
		}
	}
}
