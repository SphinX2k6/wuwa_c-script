using System;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll
{
	// Token: 0x02006F42 RID: 28482
	public static class BigStuffedDefine
	{
		// Token: 0x060454A6 RID: 283814 RVA: 0x01125D74 File Offset: 0x01123F74
		public static int calculateCellSize(int startIndex, int endIndex)
		{
			if (endIndex >= startIndex)
			{
				return endIndex - startIndex + 1;
			}
			return 36 - startIndex + 1 + endIndex;
		}

		// Token: 0x04024236 RID: 148022
		public const int BIGSTUFFEDDOLL_RINGCELLCOUNT = 36;

		// Token: 0x04024237 RID: 148023
		public const float SINGLECELL_ANGLE = 10f;
	}
}
