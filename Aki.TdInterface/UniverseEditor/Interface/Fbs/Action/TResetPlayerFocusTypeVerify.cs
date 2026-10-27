using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200776D RID: 30573
	public static class TResetPlayerFocusTypeVerify
	{
		// Token: 0x0603786F RID: 227439 RVA: 0x00783BD0 File Offset: 0x00781DD0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IResetPlayerFocusToFixedDirectionVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IResetPlayerFocusToDefaultDirectionVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
