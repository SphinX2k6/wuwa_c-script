using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F71 RID: 32625
	public static class TPathLineFacingConfigVerify
	{
		// Token: 0x0603ACEC RID: 240876 RVA: 0x007E7928 File Offset: 0x007E5B28
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPathLineFacingCustomDirectionVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IPathLineFacingCurrentDirectionVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
