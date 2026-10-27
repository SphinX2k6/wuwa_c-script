using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CA7 RID: 23719
	public static class TSpawnMonsterCompleteConditionVerify
	{
		// Token: 0x060289D0 RID: 166352 RVA: 0x00594E88 File Offset: 0x00593088
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
