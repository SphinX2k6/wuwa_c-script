using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E4C RID: 3660
	[NullableContext(1)]
	[Nullable(0)]
	public class TComponentsData
	{
		// Token: 0x060052A6 RID: 21158 RVA: 0x000CB5CE File Offset: 0x000C97CE
		public static TComponentsData Create(TComponentsData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TComponentsData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001BCB RID: 7115
		// (get) Token: 0x060052A7 RID: 21159 RVA: 0x000CB5F0 File Offset: 0x000C97F0
		public virtual List<TComponentData> Items
		{
			get
			{
				if (this._ItemsInited)
				{
					return this._ItemsCache;
				}
				this._ItemsInited = true;
				int itemsLength = this.Instance.ItemsLength;
				this._ItemsCache = new List<TComponentData>(itemsLength);
				for (int i = 0; i < itemsLength; i++)
				{
					this._ItemsCache.Add(TComponentData.Create(this.Instance.Items(i)));
				}
				return this._ItemsCache;
			}
		}

		// Token: 0x04002FA3 RID: 12195
		private TComponentsData Instance;

		// Token: 0x04002FA4 RID: 12196
		private List<TComponentData> _ItemsCache;

		// Token: 0x04002FA5 RID: 12197
		private bool _ItemsInited;
	}
}
