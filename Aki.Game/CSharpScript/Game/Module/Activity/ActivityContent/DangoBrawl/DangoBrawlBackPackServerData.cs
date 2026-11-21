using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200570E RID: 22286
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlBackPackServerData
	{
		// Token: 0x170069F1 RID: 27121
		// (get) Token: 0x06036DBA RID: 224698 RVA: 0x00F4BE41 File Offset: 0x00F4A041
		// (set) Token: 0x06036DBB RID: 224699 RVA: 0x00F4BE4C File Offset: 0x00F4A04C
		public DangoBrawlNormalBagItemInfo[] MyInfoList
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
					DangoBrawlNormalBagItemInfo dangoBrawlNormalBagItemInfo = value[i];
					int uid = dangoBrawlNormalBagItemInfo.Inst.Uid;
					this.ItemMap[uid] = new DangoBrawlBackPackItemServerData(dangoBrawlNormalBagItemInfo);
				}
			}
		}

		// Token: 0x06036DBC RID: 224700 RVA: 0x00F4BE9D File Offset: 0x00F4A09D
		public List<DangoBrawlBackPackItemServerData> GetItemList()
		{
			return new List<DangoBrawlBackPackItemServerData>(this.ItemMap.Values);
		}

		// Token: 0x0401D0F7 RID: 119031
		private DangoBrawlNormalBagItemInfo[] InfoList = Array.Empty<DangoBrawlNormalBagItemInfo>();

		// Token: 0x0401D0F8 RID: 119032
		private readonly Dictionary<int, DangoBrawlBackPackItemServerData> ItemMap = new Dictionary<int, DangoBrawlBackPackItemServerData>();
	}
}
