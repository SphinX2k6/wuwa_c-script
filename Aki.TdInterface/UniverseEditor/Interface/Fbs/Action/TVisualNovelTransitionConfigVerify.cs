using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007818 RID: 30744
	public static class TVisualNovelTransitionConfigVerify
	{
		// Token: 0x06037BF1 RID: 228337 RVA: 0x00789120 File Offset: 0x00787320
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
