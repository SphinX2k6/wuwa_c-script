using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067C0 RID: 26560
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlBenchServerData
	{
		// Token: 0x170096B3 RID: 38579
		// (get) Token: 0x0604226B RID: 270955 RVA: 0x0100AB1C File Offset: 0x01008D1C
		// (set) Token: 0x0604226C RID: 270956 RVA: 0x0100AB24 File Offset: 0x01008D24
		public DangoBrawlBenchItemInfo[] MyInfoList
		{
			get
			{
				return this.InfoList;
			}
			set
			{
				this.InfoList = value;
				this.ItemMap.Clear();
				for (int i = 0; i < value.Length; i++)
				{
					DangoBrawlBenchItemInfo dangoBrawlBenchItemInfo = value[i];
					int uid = dangoBrawlBenchItemInfo.Inst.Uid;
					this.ItemMap[uid] = new DangoBrawlBenchItemServerData(dangoBrawlBenchItemInfo);
				}
			}
		}

		// Token: 0x0604226D RID: 270957 RVA: 0x0100AB75 File Offset: 0x01008D75
		public List<DangoBrawlBenchItemServerData> GetItemList()
		{
			return new List<DangoBrawlBenchItemServerData>(this.ItemMap.Values);
		}

		// Token: 0x0604226E RID: 270958 RVA: 0x0100AB88 File Offset: 0x01008D88
		public static DangoBrawlBenchItemServerData MakeData(int uid, int configId)
		{
			DangoBrawlBenchItemInfo dangoBrawlBenchItemInfo = DangoBrawlBenchItemInfo.Create();
			DangoBrawlBaseItemInfo dangoBrawlBaseItemInfo = DangoBrawlBaseItemInfo.Create();
			dangoBrawlBaseItemInfo.Uid = uid;
			dangoBrawlBaseItemInfo.ConfigId = configId;
			dangoBrawlBenchItemInfo.Inst = dangoBrawlBaseItemInfo;
			return new DangoBrawlBenchItemServerData(dangoBrawlBenchItemInfo);
		}

		// Token: 0x0402289D RID: 141469
		private DangoBrawlBenchItemInfo[] InfoList = Array.Empty<DangoBrawlBenchItemInfo>();

		// Token: 0x0402289E RID: 141470
		private readonly Dictionary<int, DangoBrawlBenchItemServerData> ItemMap = new Dictionary<int, DangoBrawlBenchItemServerData>();
	}
}
