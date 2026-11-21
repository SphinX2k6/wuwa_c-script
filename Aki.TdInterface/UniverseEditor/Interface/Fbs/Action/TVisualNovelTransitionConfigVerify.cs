using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200805C RID: 32860
	public static class TVisualNovelTransitionConfigVerify
	{
		// Token: 0x0603B1AE RID: 242094 RVA: 0x007EEC98 File Offset: 0x007ECE98
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IVisualNovelTransitionTimeVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IVisualNovelTransitionLocationVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
