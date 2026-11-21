using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C63 RID: 19555
	public static class TEffectConfigMonsterDeathVerify
	{
		// Token: 0x0601E007 RID: 122887 RVA: 0x00434AEC File Offset: 0x00432CEC
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
