using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005162 RID: 20834
	public static class IOnlinePlayerConditionTarget_UnionVerify
	{
		// Token: 0x06020C5E RID: 134238 RVA: 0x00489CE4 File Offset: 0x00487EE4
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
