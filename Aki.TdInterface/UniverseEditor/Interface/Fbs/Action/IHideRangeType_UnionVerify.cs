using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FAC RID: 28588
	public static class IHideRangeType_UnionVerify
	{
		// Token: 0x060317E4 RID: 202724 RVA: 0x006B55D8 File Offset: 0x006B37D8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IHideRangeTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IHideWorldMonsterAndMonsterTreasureVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IHideWorldEntityAndLevelPlayVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IHideSpecifyEntityVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
