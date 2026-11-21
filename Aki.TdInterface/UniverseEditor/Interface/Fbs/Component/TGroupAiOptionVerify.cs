using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006251 RID: 25169
	public static class TGroupAiOptionVerify
	{
		// Token: 0x0602AD6E RID: 175470 RVA: 0x005D9664 File Offset: 0x005D7864
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IGroupAiModeDefaultVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IGroupAiMonsterEcologyVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IGroupAiPatrolVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
