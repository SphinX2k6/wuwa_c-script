using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007524 RID: 29988
	public static class IPreprocessOperationConfig_UnionVerify
	{
		// Token: 0x06034974 RID: 215412 RVA: 0x00713DE4 File Offset: 0x00711FE4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IFloatingSubtitleLanguageDiffVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IPreprocessOperationConfigVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
