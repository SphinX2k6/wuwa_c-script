using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D5D RID: 19805
	public static class TTwoDimensionOutlineNodeVerify
	{
		// Token: 0x0601EB1E RID: 125726 RVA: 0x0044B360 File Offset: 0x00449560
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ITwoDimensionOutlineItemNodeVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ITwoDimensionOutlineFolderNodeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
