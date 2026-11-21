using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.View.InstanceEntrance
{
	// Token: 0x02004EF5 RID: 20213
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityEntranceDropDownContentData
	{
		// Token: 0x06032CE3 RID: 208099 RVA: 0x00E43922 File Offset: 0x00E41B22
		public int GetDataIndex()
		{
			return this.DataIndex;
		}

		// Token: 0x06032CE4 RID: 208100 RVA: 0x00E4392A File Offset: 0x00E41B2A
		public string GetTogOptionText()
		{
			if (this.GetTogOptionTextFunc == null)
			{
				return string.Empty;
			}
			return this.GetTogOptionTextFunc(this.DataIndex);
		}

		// Token: 0x06032CE5 RID: 208101 RVA: 0x00E4394B File Offset: 0x00E41B4B
		public string GetDropDownText()
		{
			if (this.GetDropDownTextFunc == null)
			{
				return string.Empty;
			}
			return this.GetDropDownTextFunc(this.DataIndex);
		}

		// Token: 0x06032CE6 RID: 208102 RVA: 0x00E4396C File Offset: 0x00E41B6C
		public int GetRecommendLevel()
		{
			if (this.GetRecommendLevelFunc == null)
			{
				return 0;
			}
			return this.GetRecommendLevelFunc(this.DataIndex);
		}

		// Token: 0x06032CE7 RID: 208103 RVA: 0x00E43989 File Offset: 0x00E41B89
		public Action<ActivityInstanceEntranceData, int> GetOnSelectCallBack()
		{
			return this.GetOnSelectCallBackFunc;
		}

		// Token: 0x06032CE8 RID: 208104 RVA: 0x00E43991 File Offset: 0x00E41B91
		public static ActivityEntranceDropDownContentData Create(int dataIndex, Func<int, string> getTogOptionTextFunc, Func<int, string> getDropDownTextFunc, Func<int, int> getRecommendLevelFunc, Action<ActivityInstanceEntranceData, int> getOnSelectCallBack)
		{
			return new ActivityEntranceDropDownContentData
			{
				DataIndex = dataIndex,
				GetTogOptionTextFunc = getTogOptionTextFunc,
				GetDropDownTextFunc = getDropDownTextFunc,
				GetRecommendLevelFunc = getRecommendLevelFunc,
				GetOnSelectCallBackFunc = getOnSelectCallBack
			};
		}

		// Token: 0x0401AF8F RID: 110479
		private int DataIndex;

		// Token: 0x0401AF90 RID: 110480
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Func<int, string> GetTogOptionTextFunc;

		// Token: 0x0401AF91 RID: 110481
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Func<int, string> GetDropDownTextFunc;

		// Token: 0x0401AF92 RID: 110482
		[Nullable(2)]
		private Func<int, int> GetRecommendLevelFunc;

		// Token: 0x0401AF93 RID: 110483
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<ActivityInstanceEntranceData, int> GetOnSelectCallBackFunc;
	}
}
