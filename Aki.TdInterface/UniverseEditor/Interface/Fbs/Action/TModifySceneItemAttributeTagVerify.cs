using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F41 RID: 32577
	public static class TModifySceneItemAttributeTagVerify
	{
		// Token: 0x0603AC04 RID: 240644 RVA: 0x007E63E4 File Offset: 0x007E45E4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IModifyTargetSceneItemAttributeTagVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IModifySelfSceneItemAttributeTagVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
