using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058C3 RID: 22723
	public static class IGroupAiMode_UnionVerify
	{
		// Token: 0x06024E35 RID: 151093 RVA: 0x00510B4C File Offset: 0x0050ED4C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IGroupAiModeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IGroupAiModeDefaultVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IGroupAiPatrolVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IGroupAiMonsterEcologyVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
