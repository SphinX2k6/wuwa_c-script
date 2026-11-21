using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200479C RID: 18332
	public static class TWarningPreformConfigVerify
	{
		// Token: 0x0601AFD4 RID: 110548 RVA: 0x003D31F8 File Offset: 0x003D13F8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IWarningPreformFadeInScreenVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IWarningPreformActivateStateRecordEntityVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
