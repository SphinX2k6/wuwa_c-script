using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EFF RID: 32511
	public static class THideGroupConfigVerify
	{
		// Token: 0x0603AA5C RID: 240220 RVA: 0x007E3858 File Offset: 0x007E1A58
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IHideSpecifyDataLayersVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IHideSpecifyEntityGroupVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IHideSpecifyLevelPlayGroupVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IHideWorldEntityAndLevelPlayGroupVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IHideWorldMonsterAndMonsterTreasureGroupVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
