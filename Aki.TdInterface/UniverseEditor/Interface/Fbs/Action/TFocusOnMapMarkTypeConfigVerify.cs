using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076D9 RID: 30425
	public static class TFocusOnMapMarkTypeConfigVerify
	{
		// Token: 0x06037537 RID: 226615 RVA: 0x0077EB64 File Offset: 0x0077CD64
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
