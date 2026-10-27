using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042C5 RID: 17093
	public static class TCommonEventTypeVerify
	{
		// Token: 0x060195AA RID: 103850 RVA: 0x003A3674 File Offset: 0x003A1874
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
