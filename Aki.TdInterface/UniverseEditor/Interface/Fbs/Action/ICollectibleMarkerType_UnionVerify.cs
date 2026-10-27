using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006453 RID: 25683
	public static class ICollectibleMarkerType_UnionVerify
	{
		// Token: 0x0602C727 RID: 182055 RVA: 0x00618AE8 File Offset: 0x00616CE8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPlaceholderCollectibleMarkerTypeVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ICollectibleMarkerTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
