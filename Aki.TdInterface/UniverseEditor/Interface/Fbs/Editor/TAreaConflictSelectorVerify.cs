using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048E5 RID: 18661
	public static class TAreaConflictSelectorVerify
	{
		// Token: 0x0601D2FF RID: 119551 RVA: 0x0041E770 File Offset: 0x0041C970
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
