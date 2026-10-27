using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007649 RID: 30281
	public static class TBattleStatePerceptionBehaviorVerify
	{
		// Token: 0x0603723B RID: 225851 RVA: 0x00779F98 File Offset: 0x00778198
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
