using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005765 RID: 22373
	public static class IPointGroupGenerateType_UnionVerify
	{
		// Token: 0x060257E2 RID: 153570 RVA: 0x0052C248 File Offset: 0x0052A448
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
