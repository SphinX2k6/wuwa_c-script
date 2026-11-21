using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200804A RID: 32842
	public static class TVisualNovelBackgroundVerify
	{
		// Token: 0x0603B144 RID: 241988 RVA: 0x007EE218 File Offset: 0x007EC418
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
