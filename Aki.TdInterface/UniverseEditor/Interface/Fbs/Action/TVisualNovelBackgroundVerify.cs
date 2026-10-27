using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200780C RID: 30732
	public static class TVisualNovelBackgroundVerify
	{
		// Token: 0x06037B9F RID: 228255 RVA: 0x007888A0 File Offset: 0x00786AA0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IVisualNovelBackgroundLoadVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IVisualNovelBackgroundCleanVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
