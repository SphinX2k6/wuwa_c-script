using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005710 RID: 22288
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlBenchServerData
	{
		// Token: 0x170069F4 RID: 27124
		// (get) Token: 0x06036DC1 RID: 224705 RVA: 0x00F4BF00 File Offset: 0x00F4A100
		// (set) Token: 0x06036DC2 RID: 224706 RVA: 0x00F4BF08 File Offset: 0x00F4A108
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

		// Token: 0x06036DC3 RID: 224707 RVA: 0x00F4BF59 File Offset: 0x00F4A159
		public List<DangoBrawlBenchItemServerData> GetItemList()
		{
			return new List<DangoBrawlBenchItemServerData>(this.ItemMap.Values);
		}

		// Token: 0x06036DC4 RID: 224708 RVA: 0x00F4BF6C File Offset: 0x00F4A16C
		public static DangoBrawlBenchItemServerData MakeData(int uid, int configId)
		{
			DangoBrawlBenchItemInfo dangoBrawlBenchItemInfo = DangoBrawlBenchItemInfo.Create();
			DangoBrawlBaseItemInfo dangoBrawlBaseItemInfo = DangoBrawlBaseItemInfo.Create();
			dangoBrawlBaseItemInfo.Uid = uid;
			dangoBrawlBaseItemInfo.ConfigId = configId;
			dangoBrawlBenchItemInfo.Inst = dangoBrawlBaseItemInfo;
			return new DangoBrawlBenchItemServerData(dangoBrawlBenchItemInfo);
		}

		// Token: 0x0401D0FA RID: 119034
		private DangoBrawlBenchItemInfo[] InfoList = Array.Empty<DangoBrawlBenchItemInfo>();

		// Token: 0x0401D0FB RID: 119035
		private readonly Dictionary<int, DangoBrawlBenchItemServerData> ItemMap = new Dictionary<int, DangoBrawlBenchItemServerData>();
	}
}
