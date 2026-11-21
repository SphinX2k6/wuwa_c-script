using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FE1 RID: 32737
	public static class TStateOptionVerify
	{
		// Token: 0x0603AEFE RID: 241406 RVA: 0x007EA984 File Offset: 0x007E8B84
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = INotifyMonsterPerceptionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = INotifyMonsterPlayStandbyTagsVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISetBattleTagVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
