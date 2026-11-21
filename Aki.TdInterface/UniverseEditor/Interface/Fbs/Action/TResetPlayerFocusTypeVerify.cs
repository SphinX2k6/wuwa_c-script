using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F99 RID: 32665
	public static class TResetPlayerFocusTypeVerify
	{
		// Token: 0x0603ADB8 RID: 241080 RVA: 0x007E8CA0 File Offset: 0x007E6EA0
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
