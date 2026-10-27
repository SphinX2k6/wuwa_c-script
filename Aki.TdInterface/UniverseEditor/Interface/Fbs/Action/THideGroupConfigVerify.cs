using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076EB RID: 30443
	public static class THideGroupConfigVerify
	{
		// Token: 0x0603758F RID: 226703 RVA: 0x0077F34C File Offset: 0x0077D54C
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
