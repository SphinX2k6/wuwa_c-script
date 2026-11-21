using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014C6 RID: 5318
	public class IHandInItemRange
	{
		// Token: 0x060078A4 RID: 30884 RVA: 0x00120E89 File Offset: 0x0011F089
		public static IHandInItemRange Create(IHandInItemRange? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHandInItemRange
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170026BA RID: 9914
		// (get) Token: 0x060078A5 RID: 30885 RVA: 0x00120EA8 File Offset: 0x0011F0A8
		public virtual EHandInItemType HandInType
		{
			get
			{
				return (EHandInItemType)this.Instance.HandInType;
			}
		}

		// Token: 0x170026BB RID: 9915
		// (get) Token: 0x060078A6 RID: 30886 RVA: 0x00120EB8 File Offset: 0x0011F0B8
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

		// Token: 0x04004562 RID: 17762
		private IHandInItemRange Instance;

		// Token: 0x04004563 RID: 17763
		private List<int> _ItemIdsCache;

		// Token: 0x04004564 RID: 17764
		private bool _ItemIdsInited;
	}
}
