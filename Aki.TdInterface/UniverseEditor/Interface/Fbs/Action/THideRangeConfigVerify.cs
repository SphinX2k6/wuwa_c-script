using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076EE RID: 30446
	public static class THideRangeConfigVerify
	{
		// Token: 0x0603759D RID: 226717 RVA: 0x0077F4B4 File Offset: 0x0077D6B4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IHideWorldEntityAndLevelPlayVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IHideWorldMonsterAndMonsterTreasureVerify.Verify(verifier, tablePos);
				break;
			case 3:
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
