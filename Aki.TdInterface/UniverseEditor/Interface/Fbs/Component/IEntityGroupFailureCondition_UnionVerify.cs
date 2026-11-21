using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056EA RID: 22250
	public static class IEntityGroupFailureCondition_UnionVerify
	{
		// Token: 0x06023B3C RID: 146236 RVA: 0x004E8950 File Offset: 0x004E6B50
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IEntityGroupFailureConditionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IEntityGroupFailureSequentialStateVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IEntityGroupFailureArbitraryStateVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
