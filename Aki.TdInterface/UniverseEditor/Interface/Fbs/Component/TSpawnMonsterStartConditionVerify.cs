using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062DB RID: 25307
	public static class TSpawnMonsterStartConditionVerify
	{
		// Token: 0x0602B024 RID: 176164 RVA: 0x005DD70C File Offset: 0x005DB90C
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
