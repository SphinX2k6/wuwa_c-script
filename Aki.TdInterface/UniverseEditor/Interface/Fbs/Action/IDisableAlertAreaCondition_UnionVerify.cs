using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065C9 RID: 26057
	public static class IDisableAlertAreaCondition_UnionVerify
	{
		// Token: 0x0602D30B RID: 185099 RVA: 0x00631EF8 File Offset: 0x006300F8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IDisableAlertAreaConditionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IDisableAlertAreaDungeonConditionVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IDisableAlertAreaQuestConditionVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
