using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DE7 RID: 15847
	public static class IDungeonCondition_UnionVerify
	{
		// Token: 0x06016242 RID: 90690 RVA: 0x0033306C File Offset: 0x0033126C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IDungeonConditionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IDungeonIdConditionVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IDungeonSubTypeConditionVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
