using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005783 RID: 22403
	public static class IExtraRangeType_UnionVerify
	{
		// Token: 0x0602421D RID: 147997 RVA: 0x004F7DA8 File Offset: 0x004F5FA8
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
