using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D4A RID: 19786
	public static class TAreaConflictSelectorVerify
	{
		// Token: 0x0601EAEC RID: 125676 RVA: 0x0044AF0C File Offset: 0x0044910C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICustomShapeAreaConflictSelectorVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ILevelPlayAreaConflictSelectorVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IQuestAreaConflictSelectorVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
