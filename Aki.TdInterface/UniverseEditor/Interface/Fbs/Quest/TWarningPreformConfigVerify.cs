using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200433A RID: 17210
	public static class TWarningPreformConfigVerify
	{
		// Token: 0x06019846 RID: 104518 RVA: 0x003A77D0 File Offset: 0x003A59D0
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
