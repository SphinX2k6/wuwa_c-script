using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CCB RID: 23755
	public static class TTriggerModeVerify
	{
		// Token: 0x06028A86 RID: 166534 RVA: 0x00595F94 File Offset: 0x00594194
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISkyboxGlobalTriggerVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISkyboxDistanceTriggerVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
