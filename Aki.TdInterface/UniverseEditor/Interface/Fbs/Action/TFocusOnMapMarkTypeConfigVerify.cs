using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EE7 RID: 32487
	public static class TFocusOnMapMarkTypeConfigVerify
	{
		// Token: 0x0603A9EC RID: 240108 RVA: 0x007E2E78 File Offset: 0x007E1078
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IFocusOnQuestMapMarkVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IFocusOnCustomMapMarkVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
