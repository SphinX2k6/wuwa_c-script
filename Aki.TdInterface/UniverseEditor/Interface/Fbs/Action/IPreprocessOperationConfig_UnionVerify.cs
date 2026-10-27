using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DA9 RID: 28073
	public static class IPreprocessOperationConfig_UnionVerify
	{
		// Token: 0x06031978 RID: 203128 RVA: 0x006B86FC File Offset: 0x006B68FC
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
