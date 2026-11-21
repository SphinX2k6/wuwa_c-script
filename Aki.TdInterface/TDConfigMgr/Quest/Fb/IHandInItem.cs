using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014C5 RID: 5317
	public class IHandInItem
	{
		// Token: 0x0600789F RID: 30879 RVA: 0x00120DE1 File Offset: 0x0011EFE1
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

		// Token: 0x170026B7 RID: 9911
		// (get) Token: 0x060078A0 RID: 30880 RVA: 0x00120E00 File Offset: 0x0011F000
		public virtual EHandInItemType HandInType
		{
			get
			{
				return (EHandInItemType)this.Instance.HandInType;
			}
		}

		// Token: 0x170026B8 RID: 9912
		// (get) Token: 0x060078A1 RID: 30881 RVA: 0x00120E10 File Offset: 0x0011F010
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

		// Token: 0x170026B9 RID: 9913
		// (get) Token: 0x060078A2 RID: 30882 RVA: 0x00120E74 File Offset: 0x0011F074
		public virtual int Count
		{
			get
			{
				return this.Instance.Count;
			}
		}

		// Token: 0x0400455F RID: 17759
		private IHandInItem Instance;

		// Token: 0x04004560 RID: 17760
		private List<int> _ItemIdsCache;

		// Token: 0x04004561 RID: 17761
		private bool _ItemIdsInited;
	}
}
