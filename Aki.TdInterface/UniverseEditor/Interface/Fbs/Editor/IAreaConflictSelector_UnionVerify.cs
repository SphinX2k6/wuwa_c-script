using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004C8A RID: 19594
	public static class IAreaConflictSelector_UnionVerify
	{
		// Token: 0x0601E051 RID: 122961 RVA: 0x00435178 File Offset: 0x00433378
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
