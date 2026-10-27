using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200578F RID: 22415
	public static class IProceduralMaterialType_UnionVerify
	{
		// Token: 0x06025944 RID: 153924 RVA: 0x0052EE8C File Offset: 0x0052D08C
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
