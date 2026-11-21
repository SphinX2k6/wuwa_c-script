using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02008038 RID: 32824
	public static class TUnlockSystemOptionVerify
	{
		// Token: 0x0603B0F4 RID: 241908 RVA: 0x007EDAEC File Offset: 0x007EBCEC
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
