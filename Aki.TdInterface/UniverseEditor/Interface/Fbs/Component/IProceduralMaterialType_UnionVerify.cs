using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D96 RID: 23958
	public static class IProceduralMaterialType_UnionVerify
	{
		// Token: 0x06027E64 RID: 163428 RVA: 0x00575018 File Offset: 0x00573218
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ICustomPrimitiveDataConfigVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IProceduralMaterialTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
