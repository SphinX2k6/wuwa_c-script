using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005114 RID: 20756
	public static class IExploreSkillCondition_UnionVerify
	{
		// Token: 0x06020A08 RID: 133640 RVA: 0x00485E70 File Offset: 0x00484070
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ICheckPlayerAirBubbleEnabledVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IExploreSkillConditionVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
