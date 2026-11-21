using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E51 RID: 32337
	public static class TAlertValueChangeSpeedVerify
	{
		// Token: 0x0603A6C8 RID: 239304 RVA: 0x007DDE9C File Offset: 0x007DC09C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ICustomAlertValueChangeSpeedVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IAddOrSubAlertValueChangeSpeedVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
