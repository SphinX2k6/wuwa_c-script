using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005946 RID: 22854
	public static class ISpawnConfigType_UnionVerify
	{
		// Token: 0x06026AC1 RID: 158401 RVA: 0x00553598 File Offset: 0x00551798
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
