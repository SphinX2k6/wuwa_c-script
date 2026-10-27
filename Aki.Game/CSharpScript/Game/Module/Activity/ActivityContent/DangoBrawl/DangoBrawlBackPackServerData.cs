using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067BE RID: 26558
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlBackPackServerData
	{
		// Token: 0x170096B0 RID: 38576
		// (get) Token: 0x06042264 RID: 270948 RVA: 0x0100AA5D File Offset: 0x01008C5D
		// (set) Token: 0x06042265 RID: 270949 RVA: 0x0100AA68 File Offset: 0x01008C68
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

		// Token: 0x06042266 RID: 270950 RVA: 0x0100AAB9 File Offset: 0x01008CB9
		public List<DangoBrawlBackPackItemServerData> GetItemList()
		{
			return new List<DangoBrawlBackPackItemServerData>(this.ItemMap.Values);
		}

		// Token: 0x0402289A RID: 141466
		private DangoBrawlNormalBagItemInfo[] InfoList = Array.Empty<DangoBrawlNormalBagItemInfo>();

		// Token: 0x0402289B RID: 141467
		private readonly Dictionary<int, DangoBrawlBackPackItemServerData> ItemMap = new Dictionary<int, DangoBrawlBackPackItemServerData>();
	}
}
