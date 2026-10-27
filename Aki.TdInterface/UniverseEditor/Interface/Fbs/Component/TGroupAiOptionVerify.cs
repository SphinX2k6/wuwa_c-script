using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C2C RID: 23596
	public static class TGroupAiOptionVerify
	{
		// Token: 0x06028760 RID: 165728 RVA: 0x0059144C File Offset: 0x0058F64C
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
