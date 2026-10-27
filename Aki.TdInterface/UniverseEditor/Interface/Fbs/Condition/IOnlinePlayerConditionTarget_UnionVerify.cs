using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C69 RID: 19561
	public static class IOnlinePlayerConditionTarget_UnionVerify
	{
		// Token: 0x0601F03C RID: 127036 RVA: 0x00456194 File Offset: 0x00454394
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IOnlinePlayerConditionTargetVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IOnlinePlayerConditionTargetHostVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IOnlinePlayerConditionTargetParticipatorVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
