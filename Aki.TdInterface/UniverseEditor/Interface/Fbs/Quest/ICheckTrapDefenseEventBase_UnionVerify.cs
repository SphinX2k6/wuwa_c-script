using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004195 RID: 16789
	public static class ICheckTrapDefenseEventBase_UnionVerify
	{
		// Token: 0x060171F0 RID: 94704 RVA: 0x0034B710 File Offset: 0x00349910
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
