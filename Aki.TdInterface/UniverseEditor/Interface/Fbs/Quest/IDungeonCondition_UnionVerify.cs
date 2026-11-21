using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004222 RID: 16930
	public static class IDungeonCondition_UnionVerify
	{
		// Token: 0x06017861 RID: 96353 RVA: 0x0035BA70 File Offset: 0x00359C70
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
