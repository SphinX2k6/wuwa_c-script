using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005928 RID: 22824
	public static class ISkyboxTrigger_UnionVerify
	{
		// Token: 0x0602697B RID: 158075 RVA: 0x00550A68 File Offset: 0x0054EC68
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
