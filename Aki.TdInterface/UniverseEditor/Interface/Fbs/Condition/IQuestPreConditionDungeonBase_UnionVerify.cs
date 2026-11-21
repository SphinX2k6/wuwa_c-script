using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200519E RID: 20894
	public static class IQuestPreConditionDungeonBase_UnionVerify
	{
		// Token: 0x06020E1A RID: 134682 RVA: 0x0048CA40 File Offset: 0x0048AC40
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
