using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D8A RID: 11658
	public class HonamiStoryGetItem : ActionParams
	{
		// Token: 0x0600FE2F RID: 65071 RVA: 0x0024AD1E File Offset: 0x00248F1E
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

		// Token: 0x17004FC9 RID: 20425
		// (get) Token: 0x0600FE30 RID: 65072 RVA: 0x0024AD3D File Offset: 0x00248F3D
		public virtual int ActivityId
		{
			get
			{
				return this.Instance.ActivityId;
			}
		}

		// Token: 0x17004FCA RID: 20426
		// (get) Token: 0x0600FE31 RID: 65073 RVA: 0x0024AD4C File Offset: 0x00248F4C
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

		// Token: 0x04008AC2 RID: 35522
		private IHonamiStoryGetItem Instance;

		// Token: 0x04008AC3 RID: 35523
		private List<int> _ItemIdCache;

		// Token: 0x04008AC4 RID: 35524
		private bool _ItemIdInited;
	}
}
