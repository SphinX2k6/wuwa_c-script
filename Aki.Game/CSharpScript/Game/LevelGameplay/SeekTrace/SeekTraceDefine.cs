using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SeekTrace
{
	// Token: 0x02005BB6 RID: 23478
	[NullableContext(1)]
	[Nullable(0)]
	public class SeekTraceDefine
	{
		// Token: 0x06039B8C RID: 236428 RVA: 0x01036618 File Offset: 0x01034818
		// Note: this type is marked as 'beforefieldinit'.
		static SeekTraceDefine()
		{
			int[][] array = new int[4][];
			array[0] = new int[]
			{
				0,
				1
			};
			array[1] = new int[]
			{
				0,
				-1
			};
			int num = 2;
			int[] array2 = new int[2];
			array2[0] = 1;
			array[num] = array2;
			int num2 = 3;
			int[] array3 = new int[2];
			array3[0] = -1;
			array[num2] = array3;
			SeekTraceDefine.preSelectedOffsetList = array;
		}

		// Token: 0x0401E79C RID: 124828
		[StaticVariableRuleIgnore]
		public static readonly int[][] preSelectedOffsetList;

		// Token: 0x0401E79D RID: 124829
		public const int BIG_CONTENT_SIZE = 8;

		// Token: 0x0401E79E RID: 124830
		public const string BIG_CONTENT_KEY = "UiItem_CrosslGridB";

		// Token: 0x0401E79F RID: 124831
		public const int SMALL_CONTNET_SIZE = 5;

		// Token: 0x0401E7A0 RID: 124832
		public const string SMALL_CONTENT_KEY = "UiItem_CrosslGridS";
	}
}
