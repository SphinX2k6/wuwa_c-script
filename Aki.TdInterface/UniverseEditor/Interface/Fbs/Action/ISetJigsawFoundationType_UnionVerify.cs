using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200700F RID: 28687
	public static class ISetJigsawFoundationType_UnionVerify
	{
		// Token: 0x06032BDE RID: 207838 RVA: 0x006D8980 File Offset: 0x006D6B80
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
