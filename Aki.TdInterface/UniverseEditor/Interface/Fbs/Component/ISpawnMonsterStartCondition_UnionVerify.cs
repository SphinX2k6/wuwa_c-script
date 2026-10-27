using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005967 RID: 22887
	public static class ISpawnMonsterStartCondition_UnionVerify
	{
		// Token: 0x06026BD6 RID: 158678 RVA: 0x005556A0 File Offset: 0x005538A0
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
