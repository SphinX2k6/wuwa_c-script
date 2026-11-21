using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C2A RID: 19498
	public static class IEntityOwnerInfo_UnionVerify
	{
		// Token: 0x0601DDAB RID: 122283 RVA: 0x0042FC44 File Offset: 0x0042DE44
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
