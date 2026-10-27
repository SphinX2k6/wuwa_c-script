using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048F8 RID: 18680
	public static class TTwoDimensionOutlineNodeVerify
	{
		// Token: 0x0601D331 RID: 119601 RVA: 0x0041EBC4 File Offset: 0x0041CDC4
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
