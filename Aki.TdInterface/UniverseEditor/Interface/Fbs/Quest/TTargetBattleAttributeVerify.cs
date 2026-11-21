using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004784 RID: 18308
	public static class TTargetBattleAttributeVerify
	{
		// Token: 0x0601AF5E RID: 110430 RVA: 0x003D2710 File Offset: 0x003D0910
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ICheckPlayerBattleAttributeVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ICheckMonsterBattleAttributeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
