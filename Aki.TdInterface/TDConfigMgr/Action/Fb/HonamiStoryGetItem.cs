using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A96 RID: 10902
	[NullableContext(1)]
	[Nullable(0)]
	public class HonamiStoryGetItem : ActionParams
	{
		// Token: 0x0600EF79 RID: 61305 RVA: 0x0022D012 File Offset: 0x0022B212
		public static HonamiStoryGetItem Create(IHonamiStoryGetItem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new HonamiStoryGetItem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C0F RID: 19471
		// (get) Token: 0x0600EF7A RID: 61306 RVA: 0x0022D031 File Offset: 0x0022B231
		public virtual int ActivityId
		{
			get
			{
				return this.Instance.ActivityId;
			}
		}

		// Token: 0x17004C10 RID: 19472
		// (get) Token: 0x0600EF7B RID: 61307 RVA: 0x0022D040 File Offset: 0x0022B240
		public virtual List<int> ItemId
		{
			get
			{
				if (this._ItemIdInited)
				{
					return this._ItemIdCache;
				}
				this._ItemIdInited = true;
				int itemIdLength = this.Instance.ItemIdLength;
				this._ItemIdCache = new List<int>(itemIdLength);
				for (int i = 0; i < itemIdLength; i++)
				{
					this._ItemIdCache.Add(this.Instance.ItemId(i));
				}
				return this._ItemIdCache;
			}
		}

		// Token: 0x040083BE RID: 33726
		private IHonamiStoryGetItem Instance;

		// Token: 0x040083BF RID: 33727
		private List<int> _ItemIdCache;

		// Token: 0x040083C0 RID: 33728
		private bool _ItemIdInited;
	}
}
