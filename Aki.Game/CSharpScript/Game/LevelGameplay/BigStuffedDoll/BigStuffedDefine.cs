using System;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll
{
	// Token: 0x020060C3 RID: 24771
	public static class BigStuffedDefine
	{
		// Token: 0x0603B654 RID: 243284 RVA: 0x010CFD20 File Offset: 0x010CDF20
		public static int calculateCellSize(int startIndex, int endIndex)
		{
			if (endIndex >= startIndex)
			{
				return endIndex - startIndex + 1;
			}
			return 36 - startIndex + 1 + endIndex;
		}

		// Token: 0x0401F4EB RID: 128235
		public const int BIGSTUFFEDDOLL_RINGCELLCOUNT = 36;

		// Token: 0x0401F4EC RID: 128236
		public const float SINGLECELL_ANGLE = 10f;
	}
}
