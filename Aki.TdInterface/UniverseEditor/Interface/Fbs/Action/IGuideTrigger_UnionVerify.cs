using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068BD RID: 26813
	public static class IGuideTrigger_UnionVerify
	{
		// Token: 0x0602EC51 RID: 191569 RVA: 0x006622C8 File Offset: 0x006604C8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ICompleteGuideVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IGuideTriggerVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
