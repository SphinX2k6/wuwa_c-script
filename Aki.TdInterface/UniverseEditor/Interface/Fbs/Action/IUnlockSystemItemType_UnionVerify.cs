using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CDC RID: 31964
	public static class IUnlockSystemItemType_UnionVerify
	{
		// Token: 0x06039A8A RID: 236170 RVA: 0x007C7430 File Offset: 0x007C5630
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IUnlockSystemItemTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IUnLockCookSystemItemVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IUnlockAtlasSystemItemVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IUnlockAchievementSystemItemVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IUnlockPhotoMemoryCollectSystemItemVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IUnLockDangoCollectSystemItemVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
