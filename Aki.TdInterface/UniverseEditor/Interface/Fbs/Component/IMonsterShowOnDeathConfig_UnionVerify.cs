using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B3C RID: 23356
	public static class IMonsterShowOnDeathConfig_UnionVerify
	{
		// Token: 0x0602668F RID: 157327 RVA: 0x00542A14 File Offset: 0x00540C14
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
