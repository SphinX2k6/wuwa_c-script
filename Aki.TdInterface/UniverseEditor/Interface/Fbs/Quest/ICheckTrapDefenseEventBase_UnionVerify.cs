using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D7E RID: 15742
	public static class ICheckTrapDefenseEventBase_UnionVerify
	{
		// Token: 0x06015CB8 RID: 89272 RVA: 0x00324498 File Offset: 0x00322698
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICheckTrapDefenseEventBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICheckTrapDefenseEventMonsterKilledVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICheckTrapDefenseBdBuffQualityUpVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
