using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041B6 RID: 16822
	public static class ITargetBattleAttribute_UnionVerify
	{
		// Token: 0x06018C4D RID: 101453 RVA: 0x00390C68 File Offset: 0x0038EE68
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITargetBattleAttributeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICheckPlayerBattleAttributeVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICheckMonsterBattleAttributeVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
