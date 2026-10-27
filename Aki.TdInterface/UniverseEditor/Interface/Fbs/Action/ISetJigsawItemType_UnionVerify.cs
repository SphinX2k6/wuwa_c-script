using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007018 RID: 28696
	public static class ISetJigsawItemType_UnionVerify
	{
		// Token: 0x06032C0E RID: 207886 RVA: 0x006D8DF0 File Offset: 0x006D6FF0
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
