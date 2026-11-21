using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004721 RID: 18209
	public static class TCommonEventTypeVerify
	{
		// Token: 0x0601AD16 RID: 109846 RVA: 0x003CED4C File Offset: 0x003CCF4C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ICommonEventVarValueChangeVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ICommonEventEntityStateChangeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
