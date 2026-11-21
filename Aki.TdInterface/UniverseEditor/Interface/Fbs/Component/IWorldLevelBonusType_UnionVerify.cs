using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061AD RID: 25005
	public static class IWorldLevelBonusType_UnionVerify
	{
		// Token: 0x0602A808 RID: 174088 RVA: 0x005CC040 File Offset: 0x005CA240
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
