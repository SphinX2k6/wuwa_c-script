using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062FF RID: 25343
	public static class TTriggerModeVerify
	{
		// Token: 0x0602B0DA RID: 176346 RVA: 0x005DE804 File Offset: 0x005DCA04
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
