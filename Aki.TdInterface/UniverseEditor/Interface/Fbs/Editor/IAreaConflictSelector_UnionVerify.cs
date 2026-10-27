using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004822 RID: 18466
	public static class IAreaConflictSelector_UnionVerify
	{
		// Token: 0x0601C854 RID: 116820 RVA: 0x00408828 File Offset: 0x00406A28
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IAreaConflictSelectorVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IQuestAreaConflictSelectorVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ILevelPlayAreaConflictSelectorVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ICustomShapeAreaConflictSelectorVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
