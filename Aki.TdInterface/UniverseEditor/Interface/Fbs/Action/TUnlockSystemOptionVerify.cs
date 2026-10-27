using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077FA RID: 30714
	public static class TUnlockSystemOptionVerify
	{
		// Token: 0x06037B4F RID: 228175 RVA: 0x00788174 File Offset: 0x00786374
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IUnlockAchievementSystemItemVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IUnlockAtlasSystemItemVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IUnLockCookSystemItemVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IUnLockDangoCollectSystemItemVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IUnlockPhotoMemoryCollectSystemItemVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
