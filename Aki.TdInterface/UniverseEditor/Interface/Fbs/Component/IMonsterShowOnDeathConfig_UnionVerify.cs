using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200559E RID: 21918
	public static class IMonsterShowOnDeathConfig_UnionVerify
	{
		// Token: 0x06024482 RID: 148610 RVA: 0x0050249C File Offset: 0x0050069C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IMonsterShowOnDeathEffectVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IMonsterShowOnDeathConfigVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
