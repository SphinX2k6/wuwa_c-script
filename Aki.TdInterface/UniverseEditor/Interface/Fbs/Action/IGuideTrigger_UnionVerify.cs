using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F5E RID: 28510
	public static class IGuideTrigger_UnionVerify
	{
		// Token: 0x0603158B RID: 202123 RVA: 0x006B1744 File Offset: 0x006AF944
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
