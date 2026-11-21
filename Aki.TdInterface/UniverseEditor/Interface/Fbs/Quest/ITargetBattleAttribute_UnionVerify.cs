using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200460F RID: 17935
	public static class ITargetBattleAttribute_UnionVerify
	{
		// Token: 0x0601A3A3 RID: 107427 RVA: 0x003BC0BC File Offset: 0x003BA2BC
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
