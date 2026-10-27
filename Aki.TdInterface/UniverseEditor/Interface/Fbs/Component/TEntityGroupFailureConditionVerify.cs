using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C11 RID: 23569
	public static class TEntityGroupFailureConditionVerify
	{
		// Token: 0x060286D4 RID: 165588 RVA: 0x00590738 File Offset: 0x0058E938
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IEntityGroupFailureSequentialStateVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IEntityGroupFailureArbitraryStateVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
