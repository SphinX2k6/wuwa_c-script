using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001374 RID: 4980
	[NullableContext(1)]
	[Nullable(0)]
	public class IHandInItem
	{
		// Token: 0x060071F9 RID: 29177 RVA: 0x0011275D File Offset: 0x0011095D
		public static IHandInItem Create(IHandInItem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHandInItem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170024E4 RID: 9444
		// (get) Token: 0x060071FA RID: 29178 RVA: 0x0011277C File Offset: 0x0011097C
		public virtual EHandInItemType HandInType
		{
			get
			{
				return (EHandInItemType)this.Instance.HandInType;
			}
		}

		// Token: 0x170024E5 RID: 9445
		// (get) Token: 0x060071FB RID: 29179 RVA: 0x0011278C File Offset: 0x0011098C
		public virtual List<int> ItemIds
		{
			get
			{
				if (this._ItemIdsInited)
				{
					return this._ItemIdsCache;
				}
				this._ItemIdsInited = true;
				int itemIdsLength = this.Instance.ItemIdsLength;
				this._ItemIdsCache = new List<int>(itemIdsLength);
				for (int i = 0; i < itemIdsLength; i++)
				{
					this._ItemIdsCache.Add(this.Instance.ItemIds(i));
				}
				return this._ItemIdsCache;
			}
		}

		// Token: 0x170024E6 RID: 9446
		// (get) Token: 0x060071FC RID: 29180 RVA: 0x001127F0 File Offset: 0x001109F0
		public virtual int Count
		{
			get
			{
				return this.Instance.Count;
			}
		}

		// Token: 0x040041DE RID: 16862
		private IHandInItem Instance;

		// Token: 0x040041DF RID: 16863
		private List<int> _ItemIdsCache;

		// Token: 0x040041E0 RID: 16864
		private bool _ItemIdsInited;
	}
}
