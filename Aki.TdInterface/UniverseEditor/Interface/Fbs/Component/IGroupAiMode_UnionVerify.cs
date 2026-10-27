using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200533D RID: 21309
	public static class IGroupAiMode_UnionVerify
	{
		// Token: 0x06022D81 RID: 142721 RVA: 0x004D3C78 File Offset: 0x004D1E78
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
