using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007748 RID: 30536
	public static class TPathLineFacingConfigVerify
	{
		// Token: 0x060377AF RID: 227247 RVA: 0x00782954 File Offset: 0x00780B54
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
