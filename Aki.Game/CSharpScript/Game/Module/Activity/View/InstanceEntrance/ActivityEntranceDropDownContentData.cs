using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.View.InstanceEntrance
{
	// Token: 0x02005F0E RID: 24334
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityEntranceDropDownContentData
	{
		// Token: 0x0603DD48 RID: 253256 RVA: 0x00EF1C1A File Offset: 0x00EEFE1A
		public int GetDataIndex()
		{
			return this.DataIndex;
		}

		// Token: 0x0603DD49 RID: 253257 RVA: 0x00EF1C22 File Offset: 0x00EEFE22
		public string GetTogOptionText()
		{
			if (this.GetTogOptionTextFunc == null)
			{
				return string.Empty;
			}
			return this.GetTogOptionTextFunc(this.DataIndex);
		}

		// Token: 0x0603DD4A RID: 253258 RVA: 0x00EF1C43 File Offset: 0x00EEFE43
		public string GetDropDownText()
		{
			if (this.GetDropDownTextFunc == null)
			{
				return string.Empty;
			}
			return this.GetDropDownTextFunc(this.DataIndex);
		}

		// Token: 0x0603DD4B RID: 253259 RVA: 0x00EF1C64 File Offset: 0x00EEFE64
		public int GetRecommendLevel()
		{
			if (this.GetRecommendLevelFunc == null)
			{
				return 0;
			}
			return this.GetRecommendLevelFunc(this.DataIndex);
		}

		// Token: 0x0603DD4C RID: 253260 RVA: 0x00EF1C81 File Offset: 0x00EEFE81
		public Action<ActivityInstanceEntranceData, int> GetOnSelectCallBack()
		{
			return this.GetOnSelectCallBackFunc;
		}

		// Token: 0x0603DD4D RID: 253261 RVA: 0x00EF1C89 File Offset: 0x00EEFE89
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

		// Token: 0x040204BD RID: 132285
		private int DataIndex;

		// Token: 0x040204BE RID: 132286
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Func<int, string> GetTogOptionTextFunc;

		// Token: 0x040204BF RID: 132287
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Func<int, string> GetDropDownTextFunc;

		// Token: 0x040204C0 RID: 132288
		[Nullable(2)]
		private Func<int, int> GetRecommendLevelFunc;

		// Token: 0x040204C1 RID: 132289
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<ActivityInstanceEntranceData, int> GetOnSelectCallBackFunc;
	}
}
