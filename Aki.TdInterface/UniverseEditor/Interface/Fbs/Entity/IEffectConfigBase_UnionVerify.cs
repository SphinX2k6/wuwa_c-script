using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004BF1 RID: 19441
	public static class IEffectConfigBase_UnionVerify
	{
		// Token: 0x0601DB05 RID: 121605 RVA: 0x0042A600 File Offset: 0x00428800
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IEffectConfigBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IEffectConfigMonsterDeathVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IEffectConfigMonsterDeathGroupVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
