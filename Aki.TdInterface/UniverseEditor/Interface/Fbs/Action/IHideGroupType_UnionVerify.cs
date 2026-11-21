using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F9D RID: 28573
	public static class IHideGroupType_UnionVerify
	{
		// Token: 0x06031774 RID: 202612 RVA: 0x006B4A88 File Offset: 0x006B2C88
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
