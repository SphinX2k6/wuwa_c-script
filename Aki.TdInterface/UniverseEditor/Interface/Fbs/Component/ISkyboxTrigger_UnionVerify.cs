using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F35 RID: 24373
	public static class ISkyboxTrigger_UnionVerify
	{
		// Token: 0x06028EE5 RID: 167653 RVA: 0x005976D4 File Offset: 0x005958D4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISkyboxTriggerVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISkyboxDistanceTriggerVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISkyboxGlobalTriggerVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
