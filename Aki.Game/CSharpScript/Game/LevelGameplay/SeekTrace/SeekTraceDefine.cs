using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SeekTrace
{
	// Token: 0x02006A59 RID: 27225
	[NullableContext(1)]
	[Nullable(0)]
	public class SeekTraceDefine
	{
		// Token: 0x06043B3E RID: 277310 RVA: 0x01091DE4 File Offset: 0x0108FFE4
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

		// Token: 0x040235AA RID: 144810
		[StaticVariableRuleIgnore]
		public static readonly int[][] preSelectedOffsetList;

		// Token: 0x040235AB RID: 144811
		public const int BIG_CONTENT_SIZE = 8;

		// Token: 0x040235AC RID: 144812
		public const string BIG_CONTENT_KEY = "UiItem_CrosslGridB";

		// Token: 0x040235AD RID: 144813
		public const int SMALL_CONTNET_SIZE = 5;

		// Token: 0x040235AE RID: 144814
		public const string SMALL_CONTENT_KEY = "UiItem_CrosslGridS";
	}
}
