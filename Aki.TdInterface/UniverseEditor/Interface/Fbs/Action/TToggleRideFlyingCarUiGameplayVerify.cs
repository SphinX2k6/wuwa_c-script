using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02008020 RID: 32800
	public static class TToggleRideFlyingCarUiGameplayVerify
	{
		// Token: 0x0603B046 RID: 241734 RVA: 0x007EC8B4 File Offset: 0x007EAAB4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IEnableRideFlyingCarUiGameplayVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IDisableRideFlyingCarUiGameplayVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
