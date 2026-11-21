using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077D8 RID: 30680
	public static class ISetJigsawFoundationType_UnionVerify
	{
		// Token: 0x06035E44 RID: 220740 RVA: 0x007385C4 File Offset: 0x007367C4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISetPieceStateVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISetJigsawFoundationTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
