using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.View.InstanceEntrance
{
	// Token: 0x02005F08 RID: 24328
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityEntranceDescInfoData
	{
		// Token: 0x0603DD11 RID: 253201 RVA: 0x00EF134A File Offset: 0x00EEF54A
		public string GetName(int dataIndex)
		{
			if (this.GetNameFunc == null)
			{
				return string.Empty;
			}
			return this.GetNameFunc(dataIndex);
		}

		// Token: 0x0603DD12 RID: 253202 RVA: 0x00EF1366 File Offset: 0x00EEF566
		public string GetDesc(int dataIndex)
		{
			if (this.GetDescFunc == null)
			{
				return string.Empty;
			}
			return this.GetDescFunc(dataIndex);
		}

		// Token: 0x0603DD13 RID: 253203 RVA: 0x00EF1382 File Offset: 0x00EEF582
		public List<int> GetRecommendElement(int dataIndex)
		{
			if (this.GetRecommendElementFunc == null)
			{
				return new List<int>();
			}
			return this.GetRecommendElementFunc(dataIndex);
		}

		// Token: 0x0603DD14 RID: 253204 RVA: 0x00EF139E File Offset: 0x00EEF59E
		public static ActivityEntranceDescInfoData Create(Func<int, string> getNameFunc, Func<int, string> getDescFunc, Func<int, List<int>> getRecommendElementFunc)
		{
			return new ActivityEntranceDescInfoData
			{
				GetNameFunc = getNameFunc,
				GetDescFunc = getDescFunc,
				GetRecommendElementFunc = getRecommendElementFunc
			};
		}

		// Token: 0x040204A4 RID: 132260
		private Func<int, string> GetNameFunc;

		// Token: 0x040204A5 RID: 132261
		private Func<int, string> GetDescFunc;

		// Token: 0x040204A6 RID: 132262
		private Func<int, List<int>> GetRecommendElementFunc;
	}
}
