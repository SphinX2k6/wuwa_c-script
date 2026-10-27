using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004322 RID: 17186
	public static class TTargetBattleAttributeVerify
	{
		// Token: 0x060197D0 RID: 104400 RVA: 0x003A6CE8 File Offset: 0x003A4EE8
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
