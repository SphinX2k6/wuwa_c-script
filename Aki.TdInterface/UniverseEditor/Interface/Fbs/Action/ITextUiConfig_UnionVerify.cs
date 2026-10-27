using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073D8 RID: 29656
	public static class ITextUiConfig_UnionVerify
	{
		// Token: 0x06035E0C RID: 220684 RVA: 0x007555E4 File Offset: 0x007537E4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IAstrologyTextUiConfigVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ITextUiConfigVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
