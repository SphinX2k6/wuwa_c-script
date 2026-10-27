using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055EF RID: 21999
	public static class INavMeshSourceTypeBase_UnionVerify
	{
		// Token: 0x060247F0 RID: 149488 RVA: 0x00509904 File Offset: 0x00507B04
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
