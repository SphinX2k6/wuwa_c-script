using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062D8 RID: 25304
	public static class TSpawnMonsterCompleteConditionVerify
	{
		// Token: 0x0602B018 RID: 176152 RVA: 0x005DD5FC File Offset: 0x005DB7FC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IAllKillConditionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IDurationConditionVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IQuantityRefillConditionVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
