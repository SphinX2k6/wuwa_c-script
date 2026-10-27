using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004789 RID: 18313
	public static class IEffectConfigBase_UnionVerify
	{
		// Token: 0x0601C330 RID: 115504 RVA: 0x003FE364 File Offset: 0x003FC564
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
