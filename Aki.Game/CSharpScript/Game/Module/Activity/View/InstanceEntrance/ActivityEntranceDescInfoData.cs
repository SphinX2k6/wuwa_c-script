using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.View.InstanceEntrance
{
	// Token: 0x02004EEF RID: 20207
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityEntranceDescInfoData
	{
		// Token: 0x06032CAC RID: 208044 RVA: 0x00E43052 File Offset: 0x00E41252
		public string GetName(int dataIndex)
		{
			if (this.GetNameFunc == null)
			{
				return string.Empty;
			}
			return this.GetNameFunc(dataIndex);
		}

		// Token: 0x06032CAD RID: 208045 RVA: 0x00E4306E File Offset: 0x00E4126E
		public string GetDesc(int dataIndex)
		{
			if (this.GetDescFunc == null)
			{
				return string.Empty;
			}
			return this.GetDescFunc(dataIndex);
		}

		// Token: 0x06032CAE RID: 208046 RVA: 0x00E4308A File Offset: 0x00E4128A
		public List<int> GetRecommendElement(int dataIndex)
		{
			if (this.GetRecommendElementFunc == null)
			{
				return new List<int>();
			}
			return this.GetRecommendElementFunc(dataIndex);
		}

		// Token: 0x06032CAF RID: 208047 RVA: 0x00E430A6 File Offset: 0x00E412A6
		public static ActivityEntranceDescInfoData Create(Func<int, string> getNameFunc, Func<int, string> getDescFunc, Func<int, List<int>> getRecommendElementFunc)
		{
			return new ActivityEntranceDescInfoData
			{
				GetNameFunc = getNameFunc,
				GetDescFunc = getDescFunc,
				GetRecommendElementFunc = getRecommendElementFunc
			};
		}

		// Token: 0x0401AF76 RID: 110454
		private Func<int, string> GetNameFunc;

		// Token: 0x0401AF77 RID: 110455
		private Func<int, string> GetDescFunc;

		// Token: 0x0401AF78 RID: 110456
		private Func<int, List<int>> GetRecommendElementFunc;
	}
}
