using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02008053 RID: 32851
	public static class TVisualNovelOptionGroupConfigVerify
	{
		// Token: 0x0603B16C RID: 242028 RVA: 0x007EE5A8 File Offset: 0x007EC7A8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IVisualNovelOptionGroupNormalVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IVisualNovelOptionGroupFullScreenVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
