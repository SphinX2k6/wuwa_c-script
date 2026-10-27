using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200771B RID: 30491
	public static class TModifySceneItemAttributeTagVerify
	{
		// Token: 0x060376DB RID: 227035 RVA: 0x00781630 File Offset: 0x0077F830
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
