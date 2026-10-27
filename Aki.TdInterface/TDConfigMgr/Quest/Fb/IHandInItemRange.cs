using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001375 RID: 4981
	[NullableContext(1)]
	[Nullable(0)]
	public class IHandInItemRange
	{
		// Token: 0x060071FE RID: 29182 RVA: 0x00112805 File Offset: 0x00110A05
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

		// Token: 0x170024E7 RID: 9447
		// (get) Token: 0x060071FF RID: 29183 RVA: 0x00112824 File Offset: 0x00110A24
		public virtual EHandInItemType HandInType
		{
			get
			{
				return (EHandInItemType)this.Instance.HandInType;
			}
		}

		// Token: 0x170024E8 RID: 9448
		// (get) Token: 0x06007200 RID: 29184 RVA: 0x00112834 File Offset: 0x00110A34
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

		// Token: 0x040041E1 RID: 16865
		private IHandInItemRange Instance;

		// Token: 0x040041E2 RID: 16866
		private List<int> _ItemIdsCache;

		// Token: 0x040041E3 RID: 16867
		private bool _ItemIdsInited;
	}
}
