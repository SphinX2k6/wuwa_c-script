using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048F5 RID: 18677
	public static class TTwoDimensionLevelVerify
	{
		// Token: 0x0601D325 RID: 119589 RVA: 0x0041EAC8 File Offset: 0x0041CCC8
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
