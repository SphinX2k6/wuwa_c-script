using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FEE RID: 20462
	public static class ICheckPreloadCompleteObjectType_UnionVerify
	{
		// Token: 0x0601FED2 RID: 130770 RVA: 0x0046ECE8 File Offset: 0x0046CEE8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ICheckPreloadCompleteLinkResourceVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ICheckPreloadCompleteObjectTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
