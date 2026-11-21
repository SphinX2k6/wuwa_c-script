using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D6C RID: 23916
	public static class IPointGroupGenerateType_UnionVerify
	{
		// Token: 0x06027D02 RID: 163074 RVA: 0x005723D4 File Offset: 0x005705D4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPointGroupByLayerVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IPointGroupGenerateTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
