using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200460D RID: 17933
	public static class TLevelPlayRefreshVerify
	{
		// Token: 0x0601B2B4 RID: 111284 RVA: 0x003DECB8 File Offset: 0x003DCEB8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IChildDestroyOrAwardedRefreshVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IChildDestroyRefreshVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICompletedRefreshVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ICustomOnlineRefreshVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ICustomRefreshVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IFixedDateTimeRefreshVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = INoneRefreshVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
