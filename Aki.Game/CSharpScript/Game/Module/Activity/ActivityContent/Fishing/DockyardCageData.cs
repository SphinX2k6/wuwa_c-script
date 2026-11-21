using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200551A RID: 21786
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardCageData
	{
		// Token: 0x0603605A RID: 221274 RVA: 0x00F15480 File Offset: 0x00F13680
		public DockyardCageData(OneFishCage data)
		{
			this.Data = data;
			foreach (FishingItemInfo data2 in data.Items)
			{
				DockyardItemBlockOriginalData dockyardItemBlockOriginalData = new DockyardItemBlockOriginalData(data2);
				this.ItemDataMap.Add(dockyardItemBlockOriginalData.IncId, dockyardItemBlockOriginalData);
			}
		}

		// Token: 0x0603605B RID: 221275 RVA: 0x00F154F8 File Offset: 0x00F136F8
		public DockyardItemBlockOriginalData GetData(int uniqueId)
		{
			return this.ItemDataMap[uniqueId];
		}

		// Token: 0x0603605C RID: 221276 RVA: 0x00F15506 File Offset: 0x00F13706
		public List<DockyardItemBlockOriginalData> GetDataList()
		{
			return new List<DockyardItemBlockOriginalData>(this.ItemDataMap.Values);
		}

		// Token: 0x0401C87B RID: 116859
		public readonly OneFishCage Data;

		// Token: 0x0401C87C RID: 116860
		private readonly Dictionary<int, DockyardItemBlockOriginalData> ItemDataMap = new Dictionary<int, DockyardItemBlockOriginalData>();
	}
}
