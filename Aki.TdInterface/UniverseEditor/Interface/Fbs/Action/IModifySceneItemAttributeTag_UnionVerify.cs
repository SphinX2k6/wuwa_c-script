using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007203 RID: 29187
	public static class IModifySceneItemAttributeTag_UnionVerify
	{
		// Token: 0x06032C63 RID: 207971 RVA: 0x006DB918 File Offset: 0x006D9B18
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IModifySceneItemAttributeTagVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IModifySelfSceneItemAttributeTagVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IModifyTargetSceneItemAttributeTagVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
