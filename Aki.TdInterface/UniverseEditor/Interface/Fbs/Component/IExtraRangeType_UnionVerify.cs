using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200521B RID: 21019
	public static class IExtraRangeType_UnionVerify
	{
		// Token: 0x06022287 RID: 139911 RVA: 0x004BD2E4 File Offset: 0x004BB4E4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISunSpiritBlockExtraRangeVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IExtraRangeTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
