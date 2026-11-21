using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F74 RID: 24436
	public static class ISpawnMonsterStartCondition_UnionVerify
	{
		// Token: 0x06029140 RID: 168256 RVA: 0x0059C30C File Offset: 0x0059A50C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISpawnMonsterStartConditionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IImmediateStartConditionVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ITriggerRangeStartConditionVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
