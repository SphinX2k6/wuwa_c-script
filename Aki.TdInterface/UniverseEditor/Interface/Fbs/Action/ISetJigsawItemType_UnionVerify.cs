using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077E1 RID: 30689
	public static class ISetJigsawItemType_UnionVerify
	{
		// Token: 0x06035E74 RID: 220788 RVA: 0x00738A34 File Offset: 0x00736C34
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IMoveJigsawItemVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISetJigsawItemTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
