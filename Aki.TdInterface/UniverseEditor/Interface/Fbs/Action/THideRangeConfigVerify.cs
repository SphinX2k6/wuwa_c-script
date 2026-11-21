using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F02 RID: 32514
	public static class THideRangeConfigVerify
	{
		// Token: 0x0603AA6A RID: 240234 RVA: 0x007E39C0 File Offset: 0x007E1BC0
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
