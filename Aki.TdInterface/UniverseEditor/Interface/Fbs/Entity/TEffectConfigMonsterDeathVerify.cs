using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047FB RID: 18427
	public static class TEffectConfigMonsterDeathVerify
	{
		// Token: 0x0601C80A RID: 116746 RVA: 0x0040819C File Offset: 0x0040639C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IEffectConfigMonsterDeathGroupVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IEffectConfigMonsterDeathVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
