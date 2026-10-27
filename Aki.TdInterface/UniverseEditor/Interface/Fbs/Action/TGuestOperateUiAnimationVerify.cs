using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076E2 RID: 30434
	public static class TGuestOperateUiAnimationVerify
	{
		// Token: 0x0603755F RID: 226655 RVA: 0x0077EEE8 File Offset: 0x0077D0E8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IStopGuestUiAnimationVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IPlayGuestUiAnimationVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
