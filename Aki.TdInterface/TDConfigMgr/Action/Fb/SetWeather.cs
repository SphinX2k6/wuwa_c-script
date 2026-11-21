using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B6F RID: 11119
	[NullableContext(2)]
	[Nullable(0)]
	public class SetWeather : ActionParams
	{
		// Token: 0x0600F452 RID: 62546 RVA: 0x0023A17C File Offset: 0x0023837C
		[NullableContext(0)]
		public static SetWeather Create(ISetWeather? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetWeather
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A22 RID: 18978
		// (get) Token: 0x0600F453 RID: 62547 RVA: 0x0023A19B File Offset: 0x0023839B
		public virtual int WeatherId
		{
			get
			{
				return this.Instance.WeatherId;
			}
		}

		// Token: 0x17004A23 RID: 18979
		// (get) Token: 0x0600F454 RID: 62548 RVA: 0x0023A1A8 File Offset: 0x002383A8
		public virtual List<int> AreaIds
		{
			get
			{
				if (this._AreaIdsInited)
				{
					return this._AreaIdsCache;
				}
				this._AreaIdsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int areaIdsLength = this.Instance.AreaIdsLength;
				this._AreaIdsCache = new List<int>(areaIdsLength);
				for (int i = 0; i < areaIdsLength; i++)
				{
					this._AreaIdsCache.Add(this.Instance.AreaIds(i));
				}
				return this._AreaIdsCache;
			}
		}

		// Token: 0x040085FB RID: 34299
		private ISetWeather Instance;

		// Token: 0x040085FC RID: 34300
		private List<int> _AreaIdsCache;

		// Token: 0x040085FD RID: 34301
		private bool _AreaIdsInited;
	}
}
