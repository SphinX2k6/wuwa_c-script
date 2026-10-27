using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077A9 RID: 30633
	public static class TStateOptionVerify
	{
		// Token: 0x0603797D RID: 227709 RVA: 0x007853B4 File Offset: 0x007835B4
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
