using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F53 RID: 24403
	public static class ISpawnConfigType_UnionVerify
	{
		// Token: 0x0602902B RID: 167979 RVA: 0x0059A204 File Offset: 0x00598404
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ITemplateMatrixVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISpawnConfigTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
