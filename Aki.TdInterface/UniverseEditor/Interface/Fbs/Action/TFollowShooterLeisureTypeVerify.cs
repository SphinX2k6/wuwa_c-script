using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EEA RID: 32490
	public static class TFollowShooterLeisureTypeVerify
	{
		// Token: 0x0603A9F8 RID: 240120 RVA: 0x007E2F74 File Offset: 0x007E1174
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IFollowShooterResetToPlayerVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IFollowShooterLeaveThrowInteractionPointVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
