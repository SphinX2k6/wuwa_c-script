using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EF3 RID: 32499
	public static class TGuestOperateUiAnimationVerify
	{
		// Token: 0x0603AA20 RID: 240160 RVA: 0x007E32F8 File Offset: 0x007E14F8
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
