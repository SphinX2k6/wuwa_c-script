using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047C2 RID: 18370
	public static class IEntityOwnerInfo_UnionVerify
	{
		// Token: 0x0601C5D6 RID: 116182 RVA: 0x004039A8 File Offset: 0x00401BA8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IEntityOwnerInfoVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IEntityOwnerQuestVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IEntityOwnerLevelPlayVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IEntityOwnerEntityVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
