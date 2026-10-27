using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.View.InstanceEntrance
{
	// Token: 0x02005F0D RID: 24333
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityEntranceDropDownData
	{
		// Token: 0x0603DD43 RID: 253251 RVA: 0x00EF1BD9 File Offset: 0x00EEFDD9
		public ActivityEntranceDropDownContentData[] GetDropDownContentDataList()
		{
			return this.DropDownContentDataList;
		}

		// Token: 0x0603DD44 RID: 253252 RVA: 0x00EF1BE1 File Offset: 0x00EEFDE1
		public int GetDefaultIndex()
		{
			return this.DefaultIndex;
		}

		// Token: 0x0603DD45 RID: 253253 RVA: 0x00EF1BE9 File Offset: 0x00EEFDE9
		public void SetDefaultIndex(int index)
		{
			this.DefaultIndex = index;
		}

		// Token: 0x0603DD46 RID: 253254 RVA: 0x00EF1BF2 File Offset: 0x00EEFDF2
		public static ActivityEntranceDropDownData Create(ActivityEntranceDropDownContentData[] dropDownContentDataList, int defaultIndex)
		{
			return new ActivityEntranceDropDownData
			{
				DropDownContentDataList = dropDownContentDataList,
				DefaultIndex = defaultIndex
			};
		}

		// Token: 0x040204BB RID: 132283
		private int DefaultIndex;

		// Token: 0x040204BC RID: 132284
		private ActivityEntranceDropDownContentData[] DropDownContentDataList = Array.Empty<ActivityEntranceDropDownContentData>();
	}
}
