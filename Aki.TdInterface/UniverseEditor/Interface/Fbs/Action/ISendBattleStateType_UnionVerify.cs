using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F6E RID: 28526
	public static class ISendBattleStateType_UnionVerify
	{
		// Token: 0x0603265C RID: 206428 RVA: 0x006CDA04 File Offset: 0x006CBC04
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISendBattleStateTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = INotifyMonsterPerceptionVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISetBattleTagVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = INotifyMonsterPlayStandbyTagsVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
