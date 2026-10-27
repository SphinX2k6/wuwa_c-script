using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068F9 RID: 26873
	public static class IHideRangeType_UnionVerify
	{
		// Token: 0x0602EE14 RID: 192020 RVA: 0x006650F0 File Offset: 0x006632F0
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
