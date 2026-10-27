using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ACF RID: 27343
	public static class IModifySceneItemAttributeTag_UnionVerify
	{
		// Token: 0x0602FEAD RID: 196269 RVA: 0x00684674 File Offset: 0x00682874
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
