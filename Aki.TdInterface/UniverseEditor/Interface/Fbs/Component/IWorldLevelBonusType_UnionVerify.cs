using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B97 RID: 23447
	public static class IWorldLevelBonusType_UnionVerify
	{
		// Token: 0x06028244 RID: 164420 RVA: 0x005845B0 File Offset: 0x005827B0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IWorldLevelBonusTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IAreaBounsVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IWorldLevelTableVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
