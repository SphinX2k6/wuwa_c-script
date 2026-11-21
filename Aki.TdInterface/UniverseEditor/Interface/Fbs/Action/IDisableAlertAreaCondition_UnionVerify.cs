using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C31 RID: 27697
	public static class IDisableAlertAreaCondition_UnionVerify
	{
		// Token: 0x0602FA8F RID: 195215 RVA: 0x0067E0BC File Offset: 0x0067C2BC
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
