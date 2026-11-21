using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006230 RID: 25136
	public static class TEntityGroupFailureConditionVerify
	{
		// Token: 0x0602ACC4 RID: 175300 RVA: 0x005D8680 File Offset: 0x005D6880
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
