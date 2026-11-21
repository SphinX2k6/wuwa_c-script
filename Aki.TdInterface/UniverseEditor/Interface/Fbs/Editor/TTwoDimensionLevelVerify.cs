using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D5A RID: 19802
	public static class TTwoDimensionLevelVerify
	{
		// Token: 0x0601EB12 RID: 125714 RVA: 0x0044B264 File Offset: 0x00449464
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IMarbleLevelVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IDangoBrawlLevelVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
