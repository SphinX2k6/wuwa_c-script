using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004514 RID: 17684
	public static class ILevelPlayRefresh_UnionVerify
	{
		// Token: 0x0601A934 RID: 108852 RVA: 0x003CB784 File Offset: 0x003C9984
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ILevelPlayRefreshVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = INoneRefreshVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICompletedRefreshVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IChildDestroyRefreshVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IChildDestroyOrAwardedRefreshVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IFixedDateTimeRefreshVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = ICustomRefreshVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = ICustomOnlineRefreshVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
