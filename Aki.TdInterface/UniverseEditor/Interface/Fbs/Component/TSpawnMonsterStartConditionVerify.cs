using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CAA RID: 23722
	public static class TSpawnMonsterStartConditionVerify
	{
		// Token: 0x060289DC RID: 166364 RVA: 0x00594F98 File Offset: 0x00593198
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ITriggerRangeStartConditionVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IImmediateStartConditionVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
