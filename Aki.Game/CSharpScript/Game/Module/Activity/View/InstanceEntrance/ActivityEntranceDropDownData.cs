using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.View.InstanceEntrance
{
	// Token: 0x02004EF4 RID: 20212
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityEntranceDropDownData
	{
		// Token: 0x06032CDE RID: 208094 RVA: 0x00E438E1 File Offset: 0x00E41AE1
		public ActivityEntranceDropDownContentData[] GetDropDownContentDataList()
		{
			return this.DropDownContentDataList;
		}

		// Token: 0x06032CDF RID: 208095 RVA: 0x00E438E9 File Offset: 0x00E41AE9
		public int GetDefaultIndex()
		{
			return this.DefaultIndex;
		}

		// Token: 0x06032CE0 RID: 208096 RVA: 0x00E438F1 File Offset: 0x00E41AF1
		public void SetDefaultIndex(int index)
		{
			this.DefaultIndex = index;
		}

		// Token: 0x06032CE1 RID: 208097 RVA: 0x00E438FA File Offset: 0x00E41AFA
		public static ActivityEntranceDropDownData Create(ActivityEntranceDropDownContentData[] dropDownContentDataList, int defaultIndex)
		{
			return new ActivityEntranceDropDownData
			{
				DropDownContentDataList = dropDownContentDataList,
				DefaultIndex = defaultIndex
			};
		}

		// Token: 0x0401AF8D RID: 110477
		private int DefaultIndex;

		// Token: 0x0401AF8E RID: 110478
		private ActivityEntranceDropDownContentData[] DropDownContentDataList = Array.Empty<ActivityEntranceDropDownContentData>();
	}
}
