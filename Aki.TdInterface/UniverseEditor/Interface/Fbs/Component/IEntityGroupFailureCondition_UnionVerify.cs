using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005185 RID: 20869
	public static class IEntityGroupFailureCondition_UnionVerify
	{
		// Token: 0x06021BE4 RID: 138212 RVA: 0x004AE930 File Offset: 0x004ACB30
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
