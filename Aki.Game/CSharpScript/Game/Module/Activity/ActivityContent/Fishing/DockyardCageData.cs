using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200659C RID: 26012
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardCageData
	{
		// Token: 0x06041395 RID: 267157 RVA: 0x00FCE46C File Offset: 0x00FCC66C
		public DockyardCageData(OneFishCage data)
		{
			this.Data = data;
			foreach (FishingItemInfo data2 in data.Items)
			{
				DockyardItemBlockOriginalData dockyardItemBlockOriginalData = new DockyardItemBlockOriginalData(data2);
				this.ItemDataMap.Add(dockyardItemBlockOriginalData.IncId, dockyardItemBlockOriginalData);
			}
		}

		// Token: 0x06041396 RID: 267158 RVA: 0x00FCE4E4 File Offset: 0x00FCC6E4
		public DockyardItemBlockOriginalData GetData(int uniqueId)
		{
			return this.ItemDataMap[uniqueId];
		}

		// Token: 0x06041397 RID: 267159 RVA: 0x00FCE4F2 File Offset: 0x00FCC6F2
		public List<DockyardItemBlockOriginalData> GetDataList()
		{
			return new List<DockyardItemBlockOriginalData>(this.ItemDataMap.Values);
		}

		// Token: 0x04021F4A RID: 139082
		public readonly OneFishCage Data;

		// Token: 0x04021F4B RID: 139083
		private readonly Dictionary<int, DockyardItemBlockOriginalData> ItemDataMap = new Dictionary<int, DockyardItemBlockOriginalData>();
	}
}
