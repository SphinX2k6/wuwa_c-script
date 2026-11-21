using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B8D RID: 23437
	public static class INavMeshSourceTypeBase_UnionVerify
	{
		// Token: 0x060269FD RID: 158205 RVA: 0x00549E7C File Offset: 0x0054807C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || INavMeshAkiEntitySourceVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = INavMeshSourceTypeBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
