using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068ED RID: 26861
	public static class IHideGroupType_UnionVerify
	{
		// Token: 0x0602EDC2 RID: 191938 RVA: 0x00664940 File Offset: 0x00662B40
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IHideGroupTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IHideWorldMonsterAndMonsterTreasureGroupVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IHideWorldEntityAndLevelPlayGroupVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IHideSpecifyEntityGroupVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IHideSpecifyLevelPlayGroupVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IHideSpecifyDataLayersVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
