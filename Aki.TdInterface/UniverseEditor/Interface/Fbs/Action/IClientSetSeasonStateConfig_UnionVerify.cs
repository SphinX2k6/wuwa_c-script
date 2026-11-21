using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A76 RID: 27254
	public static class IClientSetSeasonStateConfig_UnionVerify
	{
		// Token: 0x0602EC2A RID: 191530 RVA: 0x0065F62C File Offset: 0x0065D82C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IClientSetSeasonStateConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISwitchSeasonVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ILoopSeasonChangeVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
