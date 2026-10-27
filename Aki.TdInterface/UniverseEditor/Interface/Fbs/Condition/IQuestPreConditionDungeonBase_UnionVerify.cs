using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CA5 RID: 19621
	public static class IQuestPreConditionDungeonBase_UnionVerify
	{
		// Token: 0x0601F1F8 RID: 127480 RVA: 0x00458EF0 File Offset: 0x004570F0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IQuestPreConditionDungeonIdVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IQuestPreConditionDungeonBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
