using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E57 RID: 32343
	public static class TBattleStatePerceptionBehaviorVerify
	{
		// Token: 0x0603A6E0 RID: 239328 RVA: 0x007DE094 File Offset: 0x007DC294
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPerceptionNotifyGatherToPlayerVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IPerceptionNotifyGatherToEntityVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
